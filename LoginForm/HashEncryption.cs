using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LoginForm
{
    public static class HashEncryption
    {
        //public static String CreateSalt(int size)
        //{
        //    var rng = new RNGCryptoServiceProvider();
        //    var buff = new byte[size];
        //    rng.GetBytes(buff);
        //    return Convert.ToBase64String(buff);
        //}

        public static string GenerateSHA512Hash(string input)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input);
            SHA512CryptoServiceProvider sha512 = new SHA512CryptoServiceProvider();
            byte[] hash = sha512.ComputeHash(bytes);
            
            return ByteArrayToHexString(hash);

            //StringBuilder stringValue = new StringBuilder();

            //for (int i = 0; i < hash.Length; i++)
            //{
            //    stringValue.Append(hash[i].ToString());
            //}
            //return stringValue.ToString();
        }

        public static string ByteArrayToHexString(byte[] array)
        {
            var hex = BitConverter.ToString(array);
            return hex.Replace("-", "");
        }

        public static string Encrypt(string value)
        {
            using (SHA512CryptoServiceProvider sha512CryptoService = new SHA512CryptoServiceProvider())
            {
                byte[] bytes = sha512CryptoService.ComputeHash(System.Text.Encoding.UTF8.GetBytes(value));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
