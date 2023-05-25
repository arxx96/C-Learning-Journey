using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Xml.Linq;
using System.Xml.Schema;
using static Day41.Program;

namespace Day41
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Employee em1 = new Employee();
            Console.WriteLine("Enter the number of employees:");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] emp_num = new int[num];
            foreach (int i in emp_num)
            {
                Console.WriteLine("Enter your First Name:");
                em1.fName = Console.ReadLine();
                Console.WriteLine("Enter your Last Name:");
                em1.lName = Console.ReadLine();
                Console.WriteLine("Enter the wage:");
                em1.wage = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the loggedHours:");
                em1.loggedHours = double.Parse(Console.ReadLine());
                double totalSalary = em1.wage * em1.loggedHours;
                double netSalary = totalSalary - Employee.TAX;
                Console.WriteLine($"Hello {em1.fName} {em1.lName} your salary is {netSalary}");

               

            }

           
           



        }
      
    }

}