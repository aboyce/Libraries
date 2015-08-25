using System;
using System.Runtime.InteropServices;
using System.Security;


namespace Helpers.Helpers
{
    public static class SecureStringHelper
    {
        public static string GetString(SecureString securePassword)
        {
            string insecurePassword;

            try
            {
                insecurePassword = Marshal.PtrToStringBSTR(Marshal.SecureStringToBSTR(securePassword));
            }
            catch (Exception)
            {
                insecurePassword = string.Empty;
            }

            return insecurePassword;
        }
    }
}
