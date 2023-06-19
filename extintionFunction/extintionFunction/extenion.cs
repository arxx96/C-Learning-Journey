using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace extintionFunction
{
    internal static class extenion
    {


        public static int miror(this int x)
        {
            char[] z = x.ToString().ToCharArray();
            Array.Reverse(z);
            return int.Parse(new String(z));


        }


    }
}
