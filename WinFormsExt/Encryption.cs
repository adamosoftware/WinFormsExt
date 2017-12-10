using System;
using System.Security.Cryptography;
using System.Text;

namespace AdamOneilSoftware
{
    public static class Encryption
    {
        public static string Encrypt(this string clearText, DataProtectionScope scope = DataProtectionScope.CurrentUser)
        {
            byte[] clearBytes = Encoding.ASCII.GetBytes(clearText);
            byte[] encryptedBytes = ProtectedData.Protect(clearBytes, null, scope);
            return Convert.ToBase64String(encryptedBytes);
        }

        public static string Decrypt(this string encryptedText, DataProtectionScope scope = DataProtectionScope.CurrentUser)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            byte[] clearBytes = ProtectedData.Unprotect(encryptedBytes, null, scope);
            return Encoding.ASCII.GetString(clearBytes);
        }
    }
}