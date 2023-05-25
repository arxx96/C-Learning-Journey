using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Report
    {
        public delegate bool ISValid(Employee emp);
        public void ProcessEmployee(Employee[] emp, string Title,ISValid valid )
        {
            Console.WriteLine( Title);
            foreach ( Employee e2 in emp )
            {
                if (valid(e2))
                {
                    Console.WriteLine($"{e2.Id} | {e2.Name} | {e2.gender} | {e2.TotalSale}");
                }


            }

            Console.WriteLine("\n \n ");

        }




    }
}
