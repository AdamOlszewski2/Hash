using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SHA3;
namespace FunkcjeSkrotu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MD5.MD5Hash("akjsdkjsahd"));
            Console.WriteLine(SHA1.SHA1Hash("akjsdkjsahd"));
            Console.WriteLine(SHA2.SHA256bit("akjsdkjsahd"));
            Console.WriteLine(SHA2.SHA384bit("akjsdkjsahd"));
            Console.WriteLine(SHA2.SHA512bit("akjsdkjsahd"));
        }
    }
}
