using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Day6
{
    internal class Program
    {

        //method 
        public static void printLine()
        {
            for (int i = 0; i < 5; i++) {
                Console.Write("#");

            }
            Console.WriteLine();

        }
        public static void printLi(int cnt=4,string Pattern ="##") {
            for (int i = 0; i <= cnt; i++)
            {
                Console.Write(Pattern);
            }
            Console.WriteLine();
        
        }

        //swap method
        //without ref will not be excute
        //by value : read only
        //by ref : read and write
        public static void swap(ref int x,ref int y)
        {
            int temp = x; 
            x = y; 
            y = temp;
        }

        public static void sum(int x , int y , out int s, out int m)
        {
            s = x + y;
            m = x * y;


        }


        static void Main(string[] args)
        {
          //method call

            int x, y, z;
            Console.WriteLine("PLz insert the first NO. :  ");
            x= int.Parse(Console.ReadLine());
            //caller
            // printLine();

            printLi();

            Console.WriteLine("PLz insert the second NO. :  ");
            y= int.Parse(Console.ReadLine());
            // void method caller
            //printLine();
           //if not assigen in the method
           //printLi(7,"@@@@");
            printLi();
            Console.WriteLine("PLz insert the third NO. :  ");
            z= int.Parse(Console.ReadLine());
            //printLine();
            printLi();


            int a = 5, b = 7;
            swap(ref a,ref  b);
            Console.WriteLine($"A is {a}");
            Console.WriteLine($"B is {b}");
            


            int w = 3,  l= 5, c, g;
            sum( w,l, out c,out g);
            Console.WriteLine($" sum is {c}");
            Console.WriteLine($"multiplication is {g}");

            //call method with same name

            calculater cla = new calculater();
            int va1 =10 , va2 = 15;
            double va3 = 10.4, va4 = 15.8;
            string va5="hello" , va6=" There" ;
            Console.WriteLine(cla.add(va1,va2));
            Console.WriteLine(cla.add(va3, va4));
            Console.WriteLine(cla.add(va5, va6));

            


            //call method person
            person p1 = new person(123,"arwa","abdullah",25,"training","suhar",false);

            





        }
    }
}