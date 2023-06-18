namespace linq2where
{

    class ProductStore
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating List
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore { productName = "orange ", productPrice = 1200 });
            productList.Add(new ProductStore { productName = "apple", productPrice = 1390 });
            productList.Add(new ProductStore { productName = "banana", productPrice = 3500 });
            productList.Add(new ProductStore { productName = "strawberry", productPrice = 2450 });
            productList.Add(new ProductStore { productName = "kiwi", productPrice = 1680 });
            productList.Add(new ProductStore { productName = "apple juice", productPrice = 5400 });
            productList.Add(new ProductStore { productName = "banana juice", productPrice = 1300 });

            //LINQ Query Syntax
            var result = from p in productList
                         where p.productPrice > 2000 && p.productPrice < 5000
                         select p;

            //LINQ Method Syntax. Uncomment it to see the result.
            //var result = productList.Select(p => p);

            foreach (var list in result)
            {
                Console.WriteLine("Product Name: {0} | Product Price : {1}", list.productName, list.productPrice);
            }

            Console.ReadKey();
        }
    }
}