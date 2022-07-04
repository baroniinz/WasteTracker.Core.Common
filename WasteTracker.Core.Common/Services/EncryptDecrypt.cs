using System;
using System.IO;
using System.Security.Cryptography;
using System.Text; 

namespace WasteTracker.Core.Common.Services
{
    /// <summary>
    /// EncryptDecrypt Nov 2019
    /// Updated to AES 256
    /// </summary>
    public static class EncryptDecrypt
    {

        private const string AesIV128 = @"!DFghr8edsxv#$%7"; //Must be 16 characters to be a 128 bytes
        private const string AesKey256 = @"b#fYsfdegtDF!76s34%&j8*345VdasTH"; //Must be 32 characters to be a 256 bytes

        /// <summary>
        /// AES Encryption
        /// </summary>
        /// <param name="text">text to encrypt</param>
        /// <returns>encrypted string</returns>
        public static string Encrypt(string text)
        {
            try
            {
                using var aes = Aes.Create();
                aes.IV = Encoding.UTF8.GetBytes(AesIV128.PadLeft(16));
                aes.Key = Encoding.UTF8.GetBytes(AesKey256.PadLeft(32));

                var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using var msEncrypt = new MemoryStream();
                using var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
                using (var swEncrypt = new StreamWriter(csEncrypt))
                {
                    swEncrypt.Write(text);
                }
                return Convert.ToBase64String(msEncrypt.ToArray());
            }
            catch (Exception ex)
            {
                throw new Exception($"EncryptDecrypt.Encrypt Error : {ex.Message}");
            }

        }
        /// <summary>
        /// AES Decryption
        /// </summary>
        /// <param name="text">text to un-encrypt</param>
        /// <returns>un-encrypted plain text</returns>
        public static string Decrypt(string text)
        {
            try
            {
               using var aes = Aes.Create();
                aes.IV = Encoding.UTF8.GetBytes(AesIV128.PadLeft(16));
                aes.Key = Encoding.UTF8.GetBytes(AesKey256.PadLeft(32));

                var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                var src = System.Convert.FromBase64String(text);
                // Create the streams used for decryption.
                using var msDecrypt = new MemoryStream(src);
                using var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
                using var srDecrypt = new StreamReader(csDecrypt);
                return srDecrypt.ReadToEnd();
            }
            catch (Exception ex)
            {
                throw new Exception($"EncryptDecrypt.Decrypt Error : {ex.Message}");
            }
        }

    }
}