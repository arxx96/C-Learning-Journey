using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class calculater
    {
        public int add (int x, int y)
        {
            return x + y;
        }

        //method
        public double add(double x, double y) => x + y;
        
        public string add(string x, string y) => x + y;
        public string evenOdd(int x) => (x%2==0)? "even": "odd";






    }
}
