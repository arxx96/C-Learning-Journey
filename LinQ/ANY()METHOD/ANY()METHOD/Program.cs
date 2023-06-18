namespace ANY__METHOD
{
    internal class Program
    {


        class ProductStore
        {
            public string productName { get; set; }
            public int productPrice { get; set; }
            public int inStock { get; set; }
        }
        static void Main(string[] args)
        {
            // Creating List
            IList<ProductStore> productList = new List<ProductStore>();

            productList.Add(new ProductStore { productName = "iphone 12", productPrice = 1280, inStock = 40 });
            productList.Add(new ProductStore { productName = "samsung", productPrice = 3000, inStock = 20 });
            productList.Add(new ProductStore { productName = "hwawi", productPrice = 3500, inStock = 38 });
            productList.Add(new ProductStore { productName = "iphone 14", productPrice = 2450, inStock = 23 });
            productList.Add(new ProductStore { productName = "samsung note", productPrice = 7680, inStock = 19 });

            //LINQ Method Syntax
            var result = productList.Any(p => p.inStock > 300);
            Console.Write("All Product in Stock: ");
            Console.WriteLine(result);


            Console.ReadKey();
        }
    }
}