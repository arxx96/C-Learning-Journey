namespace REVERSE
{
    internal class Program
    {

        class ProductStore
        {
            public string productName { get; set; }
            public int productPrice { get; set; }
        }
        static void Main(string[] args)
        {



            // Creating List
            IList<ProductStore> productList = new List<ProductStore>();



            productList.Add(new ProductStore { productName = "iphone 12", productPrice = 1280 });
            productList.Add(new ProductStore { productName = "samsung", productPrice = 3000 });
            productList.Add(new ProductStore { productName = "hwawi", productPrice = 3500 });
            productList.Add(new ProductStore { productName = "iphone 14", productPrice = 2450 });
            productList.Add(new ProductStore { productName = "samsung note", productPrice = 7680 });


            var result = productList.OrderBy(p => p.productPrice).Reverse();

            foreach (var list in result)
            {
                Console.WriteLine("Product Name: {0} | Product Price : {1}", list.productName, list.productPrice);
            }

            Console.ReadKey();
        }
    }
}