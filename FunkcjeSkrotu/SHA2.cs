using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FunkcjeSkrotu
{
    class SHA2
    {
        public static string SHA256bit(string input)
        {
            StringBuilder hash = new StringBuilder();
            SHA256CryptoServiceProvider sha1provider = new SHA256CryptoServiceProvider();
            byte[] bytes = sha1provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
        public static string SHA384bit(string input)
        {
            StringBuilder hash = new StringBuilder();
            SHA384CryptoServiceProvider sha1provider = new SHA384CryptoServiceProvider();
            byte[] bytes = sha1provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
        public static string SHA512bit(string input)
        {
            StringBuilder hash = new StringBuilder();
            SHA512CryptoServiceProvider sha1provider = new SHA512CryptoServiceProvider();
            byte[] bytes = sha1provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
