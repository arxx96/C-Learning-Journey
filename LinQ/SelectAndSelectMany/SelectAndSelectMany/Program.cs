using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTutorial
{
    class ProductStore
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
        public List<string> Size { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var result = from p in GetProductDetails()
                         select p;
            foreach (var r in result.SelectMany(ProductStore => ProductStore.Size))
            {
                Console.WriteLine(r);
            }
            Console.ReadKey();
        }

        //Creating List of Product
        static List<ProductStore> GetProductDetails()
        {
            List<ProductStore> product = new List<ProductStore>
            {
            new ProductStore
                {
                productName = "HardDisk",
                productPrice = 3400,
                Size = new List<string>{"240GB","500GB","1TB"}
                },
            new ProductStore
                {
                productName = "RAM",
                productPrice = 7500,
                Size = new List<string>{"4GB","8GB","16GB"}
                },
            new ProductStore
                {
                productName = "Monitor",
                productPrice = 3400,
                Size = new List<string>{"14.5 Inch","18 Inch","24 Inch"}
                }
            };
            return product;
        }
    }
}
