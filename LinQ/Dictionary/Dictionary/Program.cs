namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, int> productList = new Dictionary<string, int>();

            productList.Add("iphone 12", 1280);
            productList.Add("hwawi", 3000);
            productList.Add("samsung", 3500);
            productList.Add("iphone 13", 2450);
            productList.Add("samsung note", 7680);
           
            //Method 1
            var search = from x in productList
                         where x.Key.Contains("iphone")
                         select x;
            //Method 2
            //var search = productList.Where(p => p.Key.Contains("Disk"));

            foreach (var result in search)
            {
                Console.WriteLine("Product Name: {0}, Price: {1}", result.Key, result.Value);
            }

            Console.ReadKey();



        }
    }
}