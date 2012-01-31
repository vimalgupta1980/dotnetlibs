using System;
using System.IO;
using com.softwarekey.Client.Licensing;

using SysconCommon.Common.Environment;

namespace SysconCommon.Protection
{
    public class ClientLicense : License, IClientLicense
    {
        #region Constants

        //TODO: Update the Product ID, Encryption Key ID, Client Key, and Server Key below before using in your own products!
        private readonly Int32 product_id = 0;
        private readonly string encryption_id = null;
        private const Int32 m_minIdentifierMatches = 1;
        private readonly string client_key = null;
        private readonly string server_key = null;

        #endregion

        #region Member Variables

        private string m_licenseFilePath = "";

        #endregion

        #region Constructors

        /// <summary>Default ClientLicense constructor</summary>
        public ClientLicense(string licenseFilePath, int product_id, string encryption_id, string client_key, string server_key, string product_version)
            : base(server_key, client_key, true, true, product_id, encryption_id, product_version)
        {
            // NOTE: the two boolean arguments where the base class's constructor is
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

            //add the time servers to check against - this check occurs in the IsValid method implementation
            this.AddTimeServerCheck("time.windows.com");
            this.AddTimeServerCheck("time.nist.gov");

            //NOTE: this is an example product version -- you may remove this or use your own; however, it is imperative that the version number contains all 4 parts!
            this.ProductVersion = product_version;

            m_licenseFilePath = licenseFilePath;
        }

        #endregion

        #region Public Methods

        /// <summary>Loads a license file and stores the path for later use</summary>
        /// <param name="path">string</param>
        /// <returns>bool</returns>
        public bool LoadFile()
        {
            return base.LoadFile(m_licenseFilePath);
        }

        /// <summary>Returns true if the current license is a trial license</summary>
        public bool IsTrial
        {
            get
            {
                return false;
            }
        }

        /// <summary>Returns true if the license is valid</summary>
        /// <returns>bool</returns>
        public bool IsValid()
        {
            // we only check if it's valid every 20 runs
            LicenseError tmpError = new LicenseError(LicenseError.ERROR_NONE); ;
            // this.m_effectiveEndDate = DateTime.Today.AddDays(1);

            if (!this.CheckInstallationStatus())
            {
                //only return an error if the check failed when the web service call was made successfully,
                // implying the web service likely found the installation's status to be invalid.
                if (m_lastError.ErrorNumber == LicenseError.ERROR_WEBSERVICE_RETURNED_FAILURE)
                    return false;
            }

            //return true if we have enough matching system identifiers
            if (this.NumberOfMatchingIdentifiers < m_minIdentifierMatches)
            {
                m_lastError = new LicenseError(LicenseError.ERROR_LICENSE_SYSTEM_IDENTIFIERS_DONT_MATCH);
                return false;
            }

            // Env.SetConfigVar("run_count", run_count + 1);
            return true;
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
