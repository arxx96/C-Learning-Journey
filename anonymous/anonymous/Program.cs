namespace anonymous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
           
            //way1
            var r = lst.Where(i => i % 2 == 0);
            foreach (var item in r)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");

            //way2

            var rql = from i in lst
                      where i % 2 == 0
                      select i;
            foreach (var item in rql)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");

        }



    }
}