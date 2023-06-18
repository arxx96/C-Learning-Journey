using System.Collections;

namespace LINQwithArray
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



            ArrayList productList = new ArrayList();

            productList.Add(new ProductStore { productName = "iphone 12", productPrice = 1280 });
            productList.Add(new ProductStore { productName = "samsung", productPrice = 3000 });
            productList.Add(new ProductStore { productName = "hwawi", productPrice = 3500 });
            productList.Add(new ProductStore { productName = "iphone 14", productPrice = 2450 });
            productList.Add(new ProductStore { productName = "samsung note", productPrice = 7680 });



            //Method 1: Query Expression
            var search = from ProductStore p in productList
                         where p.productName.Contains("iphone")
                         select p;



            foreach (var result in search)
            {
                Console.WriteLine("Product Name: {0}, Price: {1}", result.productName, result.productPrice);
            }

            Console.ReadKey();

        }
    }
}