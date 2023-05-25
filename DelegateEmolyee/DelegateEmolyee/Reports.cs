using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEmolyee
{

    
    internal class Reports
    {
        public delegate bool ISValid(Employee emp);

        public void ProcessEmployee(Employee[] emp, string Title, ISValid valid)
        {
            Console.WriteLine(Title);
            foreach (Employee e2 in emp)
            {
                if (valid(e2))
                {
                    Console.WriteLine("Name  | Age  |Salary  |TotalSale ");
                    Console.WriteLine($"{e2.Name}  |{e2.age}  | {e2.Salary} |{e2.TotalSale}\n");
                }


            }

            Console.WriteLine("\n \n ");

        }


    }
}
