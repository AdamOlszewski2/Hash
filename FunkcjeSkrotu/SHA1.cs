using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FunkcjeSkrotu
{
    class SHA1
    {
        public static string SHA1Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            SHA1CryptoServiceProvider sha1provider = new SHA1CryptoServiceProvider();
            byte[] bytes = sha1provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
