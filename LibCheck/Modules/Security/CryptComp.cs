using System.Security.Cryptography;
using System.Text;

namespace LibCheck.Modules.Security {
    internal static class CryptComp {
        internal static string GeneratePassword(string password, byte[] salt) {
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

        internal static byte[] GenerateSalt() {
            byte[] salt = new byte[32];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create()) {
                rng.GetBytes(salt, 0, salt.Length);
            }
            return salt;
        }

        private static string GenerateSecurePassword(int length = 32) {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-=[]{}|;:'\",.<>?/";

            byte[] randomBytes = RandomNumberGenerator.GetBytes(length);

            StringBuilder securePassword = new StringBuilder(length);
            for (int i = 0; i < randomBytes.Length; i++)
                securePassword.Append(validChars[randomBytes[i] % validChars.Length]);
           
            return securePassword.ToString();
        }
    }
}
