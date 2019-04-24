using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkcjeSkrotu
{
    class Program
    {
        static void Main(string[] args)
        {
            md5Class md5 = new md5Class();
            Console.WriteLine(md5Class.MD5Hash("akjsdkjsahd"));
        }
    }
}
