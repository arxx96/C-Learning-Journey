namespace OperatorOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            // operator overload 

            sequare seq =new sequare(24);
            sequare seq1 = new sequare(4);
            sequare seq2 = seq * seq1;
            Console.WriteLine(seq2.size);

            sequare seq3 = seq / seq2;
            Console.WriteLine(seq3.size);
        }
    }

    internal class sequare
    {

        public double size;


        public sequare(double size)
        {
            this.size = size;
        }
        // operator overload 
        public static sequare operator *(sequare s1, sequare s2)
        {

            double value = s1.size * s2.size;
            return new sequare(value);



        }

        public static sequare operator /(sequare s1, sequare s2)
        {

            double value = s1.size / s2.size;
            return new sequare(value);



        }


    }

}