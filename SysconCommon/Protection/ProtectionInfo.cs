using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SysconCommon.Common;
using SysconCommon.Common.Environment;

namespace SysconCommon.Protection
{
    public enum LicenseType 
    {
        Trial,
        Seat,
        Expired,
        None
    }

    /// <summary>
    /// Syscons general protection mechanisms
    /// </summary>
    public class ProtectionInfo
    {
        private const string encryptionKeyId = @"281169fe-5d1b-45d2-a0c5-dccd843161dc";

        private const string clientKey = @"BwIAAACkAABSU0EyAAQAAAEAAQCtlu1Ll0F7kz+YFZL4lgoS0uV4KS/lz/O88wGZTL/eUNeSl" +
            @"KVH57kjqFBVQDNPphQ3hyoixyberh+thSGeeVkNNUZ7+y0Akj6i73GrnlihlrL/vMWtvacCrrV6Jfu9PvGVbUQJBzD848y28" +
            @"C2hWZPggGTrieiWu78pl4/dUX8FksuMXJRvHPQUTLgD6BYVDUnxugj9YTfHfh5MBw94+MXzWQoJrN7f77qXbkFq3eVyZ1mUf" +
            @"wD4MQ71KH+jQlC+Dspns93rNjCWJcWAJL+bazqlxih/w+AAStrrhF6Nk+DQoTZK8++fw1aNxH1hTN+X/JVrMoZU7KEShVZHo" +
            @"4llEQG5Le6yIAWdm+KIoV9wfAWh63dXU1JczZ/UoLTsdMiiFf58YdbH+6Q+hg1wgi/5dwBi1jy/nrOKKGtq8/f4CvyQnJlP6" +
            @"VE9jVO+NUdsX6IT4i3qj9tgddFWpsy1xYrMv4Jbi7V3wU4h8nReFQZTQimgsZ2uT6off3IxHB+NTJMkJocUkgIjoW4IIwga0" +
            @"wSb4Is8gpo5EPw6yGlDDs5DWXNPEH7LE3/ah0Z9EPXQJz6AdsVEhsy8WOO3a5l6Fy9Vk3+qOc/kgnRj/SvfUw1fNYmAnMZBO" +
            @"3gU2U3AJbkqzA7HVzIgLYoCqynx3JGLL6DdkkepHWZbYuokxPLOCuJJ12sFJqticVFqlb4xnHAFJe1g4+ZC+ahtETGFUBjvC" +
            @"AXRsUH6suSGBwf+u3oS/4A4D8NUPeW3aDKWN8thVV2oSDj4LnU=";

        private const string serverKey = @"BgIAAACkAABSU0ExAAQAAAEAAQBJNYj/2F7qFD8y3gnNJcSLNk3JdEccuVIPyL7AwC4VyXTBg/" +
            @"AbdgyP1kaPUdLjuW1XovmfhEK7Ofjqb8EP2vGcOsTNJzT+PHo6as3L7atz9r3RHGDfazUKHGJWKZrZULXGo5iVYdfT4qOyiPSasdWFT" +
            @"PI0bpyoEWa8Tiv53A0UyA==";

        static public string TrialLicenseLocation
        {
            get
            {
                return Env.GlobalConfigDataPath + "/TrialLicense.xml";
            }
        }

        static public string LicenseLocation
        {
            get
            {
                return Env.GlobalConfigDataPath + "/License.xml";
            }
        }

        public class InvalidLicenseException : Exception { }

        static public IClientLicense GetLicense(int product_id, string product_version)
        {
            return GetLicense(product_id, product_version, 0);
        }

        static public IClientLicense GetLicense(int product_id, string product_version, int option_id)
        {
            return GetLicense(product_id, product_version, false, true, false, option_id);
        }

        static public IClientLicense GetLicense(int product_id, string product_version, bool AllowSubscription, bool AllowTrial, bool AlwaysCheck, int option_id)
        {
            if (!AllowSubscription)
            {
                // string alias_path = "c:\\windows\\system32\\Trial" + product_id.ToString() + ".xml";
                string alias_path = Env.GlobalConfigDataPath + "/_program_data.xml";

                try
                {
                    if (System.IO.File.Exists(LicenseLocation))
                    {
                        var seat = new ClientLicense(LicenseLocation, product_id, encryptionKeyId, clientKey, serverKey, product_version);
                        var loadr = seat.LoadFile();

                        // make sure the option is valid
                        if (option_id > 0 && option_id != seat.ProdOptionID)
                        {
                            // it's not
                            System.IO.File.Move(LicenseLocation, LicenseLocation + ".option" + seat.ProdOptionID.ToString());
                            throw new InvalidLicenseException();
                        }

                        var run_count = Env.GetConfigVar("run_count", 0, true);
                        if (seat.IsValid())
                        {
                            Env.SetConfigVar("run_count", run_count + 1);
                            return seat;
                        }
                        else
                            throw new InvalidLicenseException();
                    }
                    else
                    {
                        throw new InvalidLicenseException();
                    }

                }
                catch
                {
                    if (!System.IO.File.Exists(TrialLicenseLocation))
                    {
                        var trial = new TrialLicense(LicenseLocation, TrialLicenseLocation, product_id, encryptionKeyId, clientKey, serverKey, alias_path);
                        var got_new_trial = AllowTrial ? trial.CreateFreshTrial() : trial.CreateExpiredTrial();
                        trial.LoadFile();
                        return trial;
                    }
                    else
                    {
                        var trial = new TrialLicense(LicenseLocation, TrialLicenseLocation, product_id, encryptionKeyId, clientKey, serverKey, alias_path);
                        trial.LoadFile();
                        return trial;
                    }
                }
            }
            else
            {
                // check for subscription license
                throw new NotImplementedException();
            }
        }

        static public bool CheckLicense(int product_id, string product_version, int option_id)
        {
            var license = GetLicense(product_id, product_version, option_id);
            if (license.IsTrial)
            {
                var frm = new ProtectionPlusIntroFormFull(license as TrialLicense);
                frm.ShowDialog();
                return frm.LicenseOK;
            }
            else
            {
                return license.IsValid();
            }
        }

        static public bool CheckLicense(int product_id, string product_version)
        {
            var license = GetLicense(product_id, product_version);
            if (license.IsTrial)
            {
                var frm = new ProtectionPlusIntroFormFull(license as TrialLicense);
                frm.ShowDialog();
                return frm.LicenseOK;
            }
            else
            {
                return license.IsValid();
            }
        }
    }
}
