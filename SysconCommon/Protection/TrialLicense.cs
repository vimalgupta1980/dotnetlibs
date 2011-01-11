using System;
using System.IO;
using com.softwarekey.Client.Licensing;

namespace SysconCommon.Protection
{
    public class TrialLicense : WritableLicense, IClientLicense
    {
        #region Constants

        //TODO: Update the Product ID, Encryption Key ID, Client Key, and Server Key below before using in your own products!
        private readonly Int32 product_id = 0;
        private readonly string encryption_id = null;
        private readonly Int32 m_minIdentifierMatches = 1;
        private readonly string client_key = null;
        private readonly string server_key = null;

        private const int m_trialDays = 10;
        private const int m_aliasesRequired = 1;

        #endregion

        #region Member Variables

        private string m_trialLicenseFilePath = "";
        private string m_licenseFilePath = "";

        #endregion

        #region Constructors

        /// <summary>Default ClientLicense constructor</summary>
        public TrialLicense(string licenseFilePath, string trialLicenseFilePath, int product_id, string encryption_id, string client_key, string server_key, string alias_path)
            : base(server_key, client_key, true, true, product_id, "", "")
        {
            //NOTE: the two boolean arguments where the base class's constructor is
            // called above are for using an encrypted License File and encrypting
            // web service calls, respectively.

            this.product_id = product_id;
            this.encryption_id = encryption_id;
            this.client_key = client_key;
            this.server_key = server_key;
            base.m_encryptionKeyId = encryption_id;

            //initialize computer/system identifying information for the current system
            this.AddIdentifierAlgorithm(new NicIdentifierAlgorithm());
            this.AddIdentifierAlgorithm(new ComputerNameIdentifierAlgorithm());
            this.AddIdentifierAlgorithm(new HardDiskVolumeSerialIdentifierAlgorithm());
            this.InitializeCurrentIdentifiers();

            //TODO: For this example application, we are just storing the aliases in the same folder as the license.  You should change this for your application!
            // string aliasPath = licenseFilePath.Substring(0, licenseFilePath.LastIndexOf("/") + 1);

            //TODO: update the alias paths and set the last argument to false ONLY if you wish to DISABLE encryption
            this.AddAlias(new LicenseFileSystemAlias(alias_path, client_key, true));
            //this.AddAlias(new LicenseFileSystemAlias(aliasPath + "TrialLicenseAlias2.xml", client_key, true));
            this.AddAlias(new LicenseWindowsRegistryAlias("\\Software\\Syscon\\TM\\Trial", client_key, true, Microsoft.Win32.RegistryHive.CurrentUser, "TrialLicenseAlias3"));
            //this.AddAlias(new LicenseWindowsRegistryAlias("Software\\PLUSManaged\\Samples\\UnmanagedTrial", client_key, true, Microsoft.Win32.RegistryHive.CurrentUser, "TrialLicenseAlias4"));

            //add the time servers to check against - this check occurs in the IsValid method implementation
            this.AddTimeServerCheck("time.windows.com");
            this.AddTimeServerCheck("time.nist.gov");

            //NOTE: this is an example product version -- you may remove this or use your own; however, it is imperative that the version number contains all 4 parts!
            this.ProductVersion = "1.0.0.4";

            m_licenseFilePath = licenseFilePath;
            m_trialLicenseFilePath = trialLicenseFilePath;
        }

        #endregion

        #region Public Methods

        /// <summary>Loads a license file and stores the path for later use</summary>
        /// <param name="path">string</param>
        /// <returns>bool</returns>
        public bool LoadFile()
        {
            return base.LoadFile(m_trialLicenseFilePath);
        }

        /// <summary>Returns true if the current license is a trial license</summary>
        public bool IsTrial
        {
            get
            {
                return true;
            }
        }

        public int DaysLeft
        {
            get
            {
                var diff = this.m_effectiveEndDate - DateTime.UtcNow;
                return Convert.ToInt32(Math.Ceiling(diff.TotalDays));
            }
        }

        /// <summary>Returns true if the license is valid</summary>
        /// <returns>bool</returns>
        public bool IsValid()
        {
            
            //Check the aliases...
            int aliasesToCheck, validAliases;
            bool aliasesValid = false;
            LicenseError aliasesError;

            //Check the aliases (which initializes information about them)
            aliasesValid = this.CheckAliases(out aliasesToCheck, out validAliases);
            aliasesError = this.m_lastError;
            

            //make sure the last date the license was updated isn't in the future
            try
            {
                if (this.LastUpdated > DateTime.UtcNow)
                {
                    m_lastError = new LicenseError(LicenseError.ERROR_LICENSE_EXPIRED);
                    return false;
                }
            }
            catch (Exception ex)
            {
                m_lastError = new LicenseError(LicenseError.ERROR_LICENSE_ALIAS_VALIDATION_TIME_MISMATCH, ex);
                return false;
            }

           
            //Now that alias data is initialized, see if we need to overwrite the license file with a more recent alias
            LicenseAlias mostRecent = LicenseAlias.GetMostCurrentAlias(this.Aliases);
            if (mostRecent.LastUpdated > this.LastUpdated)
            {
                this.WriteAliasToLicenseFile(mostRecent, m_trialLicenseFilePath);
                int aliasesToWrite, aliasesWritten;
                this.WriteAliases(out aliasesToWrite, out aliasesWritten);
            }
            

            
            //Now also check the alias validation results
            if (!aliasesValid)
            {
                if (validAliases < m_aliasesRequired || aliasesError.ErrorNumber == LicenseError.ERROR_LICENSE_ALIAS_VALIDATION_TIME_MISMATCH)
                {
                    m_lastError = aliasesError;
                    return false;
                }
            }
            

            //make sure the current date isn't before the effective start date
            try
            {
                if (DateTime.Now.Date < m_effectiveStartDate.Date)
                {
                    m_lastError = new LicenseError(LicenseError.ERROR_LICENSE_NOT_EFFECTIVE_YET);
                    return false;
                }
            }
            catch (Exception ex)
            {
                m_lastError = new LicenseError(LicenseError.ERROR_INVALID_DATA, ex);
                return false;
            }

            //make sure the current date isn't after the effective end date
            try
            {
                if (DateTime.Now.Date > m_effectiveEndDate.Date)
                {
                    m_lastError = new LicenseError(LicenseError.ERROR_LICENSE_EXPIRED);
                    return false;
                }
            }
            catch (Exception ex)
            {
                m_lastError = new LicenseError(LicenseError.ERROR_INVALID_DATA, ex);
                return false;
            }

            //make sure the current system date/time is valid
            if (!this.CheckTimeAgainstServers())
            {
                //allow the NTP check to fail because it couldn't reach the time servers
                if (this.m_lastError.ErrorNumber == LicenseError.ERROR_SYSTEM_TIME_INVALID)
                {
                    return false;
                }
            }

            //return true if we have enough matching system identifiers
            if (this.NumberOfMatchingIdentifiers < m_minIdentifierMatches)
            {
                m_lastError = new LicenseError(LicenseError.ERROR_LICENSE_SYSTEM_IDENTIFIERS_DONT_MATCH);
                return false;
            }



            return true;
        }

        /// <summary>
        /// Creates a fresh trial license and returns true if successful
        /// </summary>
        /// <returns>bool</returns>
        public bool CreateFreshTrial()
        {
            //Start by loading and checking all the aliases
            int numAliases, numValidAliases;
            // this.CheckAliases(out numAliases, out numValidAliases);

            
            //If we found any aliases, write the most recent one as the license file
            LicenseAlias mostRecent = LicenseAlias.GetMostCurrentAlias(this.Aliases);
            if (mostRecent.LastUpdated != DateTime.MinValue)
            {
                this.WriteAliasToLicenseFile(mostRecent, m_trialLicenseFilePath);
                int aliasesToWrite, aliasesWritten;
                this.WriteAliases(out aliasesToWrite, out aliasesWritten);
                return true;
            }

            this.InstallationID = "";
            this.EffectiveStartDate = DateTime.Now.Date;
            this.EffectiveEndDate = DateTime.Now.Date.AddDays(m_trialDays);

            int filesToWrite, filesWritten;
            this.WriteAliases(out filesToWrite, out filesWritten);

            /*
            //TODO: you can add your own logic here to set your own requirements for how many aliases must be written
            //      ...for this example, we only require 1
            if (filesWritten < 1)
            {
                return false;
            }
             * */

            return this.WriteLicenseFile(m_trialLicenseFilePath);
        }

        /// <summary>
        /// Creates an expired trial license and returns true if successful
        /// </summary>
        /// <returns>bool</returns>
        public bool CreateExpiredTrial()
        {
            this.InstallationID = "";
            this.EffectiveStartDate = DateTime.Now.Date.AddDays(-1);
            this.EffectiveEndDate = DateTime.Now.Date.AddDays(-1);

            int filesToWrite, filesWritten;
            // this.WriteAliases(out filesToWrite, out filesWritten);

            /*
            //TODO: you can add your own logic here to set your own requirements for how many aliases must be written
            //      ...for this example, we only require 1
            if (filesWritten < 1)
            {
                return false;
            }
             */

            return this.WriteLicenseFile(m_trialLicenseFilePath);
        }

        /// <summary>Activates the license online</summary>
        /// <param name="licenseId">Int32</param>
        /// <param name="password">string</param>
        /// <returns>bool</returns>
        public bool ActivateOnline(Int32 licenseId, string password)
        {
            string licenseContent = "";

            //activate online using our endpoint configuration from app.config
            if (!this.ActivateInstallationLicenseFile(licenseId, password, "https://secure.softwarekey.com/solo/webservices/XmlActivationService.asmx", ref licenseContent))
                return false;

            return this.SaveLicenseFile(licenseContent);
        }

        /// <summary>Returns true if it successfully refreshes the license file</summary>
        /// <returns>bool</returns>
        public bool RefreshLicense()
        {
            string licenseContent = "";
            if (!base.RefreshLicense("https://secure.softwarekey.com/solo/webservices/XmlLicenseFileService.asmx", ref licenseContent))
                return false;

            //try to save the license file to the file system
            if (!SaveLicenseFile(licenseContent))
                return false;

            return true;
        }

        /// <summary>Saves a new license file to the file system</summary>
        /// <param name="lfContent">string</param>
        /// <returns>bool</returns>
        public bool SaveLicenseFile(string lfContent)
        {
            //try to save the license file to the file system
            try
            {
                File.WriteAllText(m_licenseFilePath, lfContent);
            }
            catch (Exception ex)
            {
                m_lastError = new LicenseError(LicenseError.ERROR_COULD_NOT_SAVE_LICENSE, ex);
                return false;
            }

            return true;
        }

        #endregion
    }
}
