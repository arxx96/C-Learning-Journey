using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //boxing unboxing
            string a = "9999";

           int b= Convert.ToInt32(a);
            Console.WriteLine(b);

           dynamic c = (int.TryParse(a, out int z))? z : "false" ;
            Console.WriteLine(z);

            
            //program for student mark
            
            Console.WriteLine("Enter number of student:");
            int studentNo = Convert.ToInt32(Console.ReadLine());
            int[] marks = new int[studentNo];


            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Enter the mark of student {i + 1}");




                marks[i] = int.Parse(Console.ReadLine());

                if (marks[i] >= 90)

                    Console.WriteLine("A");

                else if (marks[i] >= 80)

                    Console.WriteLine("B");

                else if (marks[i] >= 70)

                    Console.WriteLine("C");



                else if (marks[i] >= 60)

                    Console.WriteLine("D");


                else if (marks[i] <= 50)

                    Console.WriteLine("F");



                else

                    Console.WriteLine("error");
            }





            //try constent
            const double PI = 3.14159;
            
           
            double r=12;
            double area = PI * r * r;

            Console.WriteLine("the area is "+area);

            double cicum = 2* PI * r;

            Console.WriteLine(cicum);




        }
    }
}
