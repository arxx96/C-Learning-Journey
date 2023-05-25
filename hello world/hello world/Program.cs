namespace hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* try diffrent type of syntax
        adding + will print in one line
        write the code again will print it in another line*/

            Console.WriteLine("Hello, World!" + "My name is Arwa ");
            Console.WriteLine("Abdullah");

            //  assign value to diffrent type of variables & print
            string name;
            name = "ARWA";
            Console.WriteLine(name);
            int age;
            age = 25;
            Console.WriteLine(age);

            // how Hashcode work?
            int a = 10;
            int b = 7;
            Console.WriteLine(a.GetHashCode());

            object c = new object();
            Console.WriteLine(c.GetHashCode());
            object d = new object();
            Console.WriteLine(d.GetHashCode());

            //string concateation
            string f1 = "arwa";
            string f2 = "abdullah";
            Console.WriteLine($"your name is {f1} {f2}");

            //the diffrence between var & dynamic
            /*
            var e= 1;
            e = "abcd";
            Console.WriteLine(e);
            dynamic k = 9;
            k ="abcd";
            Console.WriteLine(k);
            */


            //compasion operators
            int f = 12;
            int g = 4;

            bool equal = f == g; //false
            bool notequal = f != g; //true
            bool less = f < g; //false
            bool greater = f > g; //true

            Console.WriteLine(equal);
            Console.WriteLine(notequal);
            Console.WriteLine(less);
            Console.WriteLine(greater);



            //logical operators
            bool h = true;
            bool j = false;

            bool m = h && j; //and result false
            bool n = !h; // not result false



            Console.WriteLine(m);
            Console.WriteLine(n);
            Console.WriteLine(h ^ j);//XOR result true
        }
    }
}