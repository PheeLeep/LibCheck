using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace LibCheck.Modules.Security {

    /// <summary>
    /// A class that houses cryptography functions.
    /// </summary>
    internal static class CryptComp {

        /// <summary>
        /// Hash the password.
        /// </summary>
        /// <param name="password">A password to be hash.</param>
        /// <param name="salt">A random byte salt.</param>
        /// <returns>Returns the <see cref="HMACSHA256"/> computed value in hex format.</returns>
        internal static string HashPassword(string password, byte[] salt) {
            byte[] bytePass = Encoding.UTF8.GetBytes(password);
            byte[] saltedPassword = new byte[salt.Length + bytePass.Length];
            byte[] hash;
            using (HMACSHA256 passMaker = new HMACSHA256(bytePass)) {
                Buffer.BlockCopy(salt, 0, saltedPassword, 0, salt.Length);
                Buffer.BlockCopy(bytePass, 0, saltedPassword, salt.Length, bytePass.Length);

                hash = passMaker.ComputeHash(saltedPassword);
            }
            return Convert.ToHexString(hash).ToUpper().Replace("-", "");
        }

        /// <summary>
        /// Generates the randomized bytes.
        /// </summary>
        /// <param name="length">A length of bytes to be made.</param>
        /// <returns>Returns a byte array with a specified length.</returns>
        internal static byte[] GenerateRNGBytes(int length = 32) {
            return RandomNumberGenerator.GetBytes(length);
        }

        /// <summary>
        /// Generates a randomized password to a <see cref="SecureString"/>.
        /// </summary>
        /// <param name="length">A specified length of password to be use.</param>
        /// <returns>Returns a <see cref="SecureString"/> containing randomized password.</returns>
        internal static SecureString GenerateSecurePassword(int length = 32, bool smallCaps = true,
                                                            bool largeCaps = false,
                                                            bool numbers = false,
                                                            bool symbols = false) {
            string validChars = "";
            if (smallCaps) validChars += "abcdefghijklmnopqrstuvwxyz";
            if (largeCaps) validChars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (numbers) validChars += "1234567890";
            if (symbols) validChars += "!@#$%^&*()_+-=[]{}|;:'\",.<>?/";
            if (string.IsNullOrEmpty(validChars)) return new SecureString();

            byte[] randomBytes = RandomNumberGenerator.GetBytes(length);

            SecureString securePassword = new SecureString();
            for (int i = 0; i < randomBytes.Length; i++)
                securePassword.AppendChar(validChars[randomBytes[i] % validChars.Length]);

            return securePassword;
        }

        /// <summary>
        /// Converts a <see cref="SecureString"/> value into a plaintext.
        /// </summary>
        /// <param name="secStr">A <see cref="SecureString"/> to convert.</param>
        /// <returns>Returns a plaintext, unsecured string.</returns>
        /// <exception cref="InvalidOperationException"></exception>
        internal static string ConvertToString(this SecureString secStr) {
            IntPtr ptr = IntPtr.Zero;
            try {
                ptr = Marshal.SecureStringToGlobalAllocUnicode(secStr);
                return Marshal.PtrToStringUni(ptr) ?? throw new InvalidOperationException("Failed to parse.");
            } finally {
                Marshal.ZeroFreeGlobalAllocUnicode(ptr);
            }
        }

        /// <summary>
        /// Performs a cryptography function to an input string.
        /// </summary>
        /// <param name="input">An input string to be use for encrypt/decrypt.</param>
        /// <param name="key">A key provided for encryption or decryption.</param>
        /// <param name="salt">A randomized salt value.</param>
        /// <param name="isEncrypt">Determines whether the function should perform an encryption or decryption.</param>
        /// <returns>Returns a value that has been encrypted or decrypted.</returns>
        internal static string StringCrypt(string input, byte[] key, byte[] salt, bool isEncrypt = true) {
            using (Aes aes = Aes.Create()) {
                using (var keyPB = new Rfc2898DeriveBytes(key, salt, 20000, HashAlgorithmName.SHA256)) {
                    aes.Key = keyPB.GetBytes(aes.KeySize / 8);
                    aes.IV = keyPB.GetBytes(aes.BlockSize / 8);
                    aes.Padding = PaddingMode.PKCS7;
                }

                using (ICryptoTransform crypto = isEncrypt ? aes.CreateEncryptor() : aes.CreateDecryptor()) {
                    byte[] plainBytes = isEncrypt ? Encoding.UTF8.GetBytes(input) :
                                                    Convert.FromBase64String(input);
                    byte[] res = crypto.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                    return isEncrypt ? Convert.ToBase64String(res) :
                                       Encoding.UTF8.GetString(res);
                }
            }
        }
    }
}
