namespace ToLookupOperator
{
    internal class Program
    {

        class ProductStore
        {
            public int category { get; set; }
            public string productName { get; set; }

            public string type { get; set; }
        }



        static void Main(string[] args)
        {

            // Creating List
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore { category = 1, productName = "iphone 12", type = "new" });
            productList.Add(new ProductStore { category = 2, productName = "samsung", type = "old" });
            productList.Add(new ProductStore { category = 1, productName = "hwawi", type = "new" });
            productList.Add(new ProductStore { category = 1, productName = "samsung note", type = "new" });
            productList.Add(new ProductStore { category = 2, productName = "iphone 11", type = "old" });


            var result = productList.ToLookup(p => p.category);

            foreach (var group in result)
            {
                Console.WriteLine(string.Format("Category: {0}", group.Key));
                foreach (var name in group)
                {
                    Console.WriteLine(string.Format("\tProduct Name: {0} | Type: {1}", name.productName, name.type));
                }
            }

            Console.ReadKey();




        }
    }
}