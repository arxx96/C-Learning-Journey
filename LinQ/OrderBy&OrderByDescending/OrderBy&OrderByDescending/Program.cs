﻿namespace OrderBy_OrderByDescending
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
            

            //LINQ Query Syntax
            var result = from p in productList
                         orderby p.productPrice
                         select p;

            //LINQ Method Syntax. Uncomment it to see the result.
            //var result = productList.OrderBy(p => p.productPrice);

            foreach (var list in result)
            {
                Console.WriteLine("Product Name: {0} | Product Price : {1}", list.productName, list.productPrice);
            }

            Console.ReadKey();




        }
    }
}