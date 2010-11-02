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
    public static class ProtectionInfo
    {
        public static string encryptionKeyId = @"281169fe-5d1b-45d2-a0c5-dccd843161dc";

        public static string clientKey = @"BwIAAACkAABSU0EyAAQAAAEAAQCtlu1Ll0F7kz+YFZL4lgoS0uV4KS/lz/O88wGZTL/eUNeSl" +
            @"KVH57kjqFBVQDNPphQ3hyoixyberh+thSGeeVkNNUZ7+y0Akj6i73GrnlihlrL/vMWtvacCrrV6Jfu9PvGVbUQJBzD848y28" +
            @"C2hWZPggGTrieiWu78pl4/dUX8FksuMXJRvHPQUTLgD6BYVDUnxugj9YTfHfh5MBw94+MXzWQoJrN7f77qXbkFq3eVyZ1mUf" +
            @"wD4MQ71KH+jQlC+Dspns93rNjCWJcWAJL+bazqlxih/w+AAStrrhF6Nk+DQoTZK8++fw1aNxH1hTN+X/JVrMoZU7KEShVZHo" +
            @"4llEQG5Le6yIAWdm+KIoV9wfAWh63dXU1JczZ/UoLTsdMiiFf58YdbH+6Q+hg1wgi/5dwBi1jy/nrOKKGtq8/f4CvyQnJlP6" +
            @"VE9jVO+NUdsX6IT4i3qj9tgddFWpsy1xYrMv4Jbi7V3wU4h8nReFQZTQimgsZ2uT6off3IxHB+NTJMkJocUkgIjoW4IIwga0" +
            @"wSb4Is8gpo5EPw6yGlDDs5DWXNPEH7LE3/ah0Z9EPXQJz6AdsVEhsy8WOO3a5l6Fy9Vk3+qOc/kgnRj/SvfUw1fNYmAnMZBO" +
            @"3gU2U3AJbkqzA7HVzIgLYoCqynx3JGLL6DdkkepHWZbYuokxPLOCuJJ12sFJqticVFqlb4xnHAFJe1g4+ZC+ahtETGFUBjvC" +
            @"AXRsUH6suSGBwf+u3oS/4A4D8NUPeW3aDKWN8thVV2oSDj4LnU=";

        public static string serverKey = @"BgIAAACkAABSU0ExAAQAAAEAAQBJNYj/2F7qFD8y3gnNJcSLNk3JdEccuVIPyL7AwC4VyXTBg/" +
            @"AbdgyP1kaPUdLjuW1XovmfhEK7Ofjqb8EP2vGcOsTNJzT+PHo6as3L7atz9r3RHGDfazUKHGJWKZrZULXGo5iVYdfT4qOyiPSasdWFT" +
            @"PI0bpyoEWa8Tiv53A0UyA==";

        public static string TrialLicenseLocation
        {
            get
            {
                var exedir = Env.GetEXEDirectory();
                return exedir + "/TrialLicense.xml";
            }
        }

        public static string LicenseLocation
        {
            get
            {
                var exedir = Env.GetEXEDirectory();
                return exedir + "/License.xml";
            }
        }

        public static LicenseType LicenseType
        {
            get
            {
                if (Env.FileExists(LicenseLocation))
                {
                    return Protection.LicenseType.Seat;
                }
                else if (Env.FileExists(TrialLicenseLocation))
                {
                    return Protection.LicenseType.Trial;
                }
                else
                {
                    return Protection.LicenseType.None;
                }
            }
        }
    }
}
