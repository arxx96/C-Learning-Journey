namespace LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //where 
            IList<string> productList = new List<string>()
            {
                "arwa abdullah",
                "shrooq said",
                "alaina dawod",
                "said",
                "abdullah said",
                "mohmmed",
                "bushra"
            };

            //Filtering Data
            var result = from s in productList
                         where s.Contains("abdullah")
                         select s;

            //Printing Result
            foreach (string str in result)
            {
                Console.WriteLine(str.ToString());
            }
            Console.ReadKey();

        }

    

    }
    }
