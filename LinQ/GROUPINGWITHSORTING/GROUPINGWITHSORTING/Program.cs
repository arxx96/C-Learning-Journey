namespace GROUPINGWITHSORTING
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


            //Query Syntax
            var result = from product in productList
                         group product by new { product.category, product.type } into pgroup
                         orderby pgroup.Key.category
                         select pgroup;


            //Method Syntax. Uncomment it to see the output 
            //var result = productList.GroupBy(p => new { p.category, p.type }).OrderBy(p => p.Key.category);

            foreach (var group in result)
            {
                Console.WriteLine(string.Format("Category: {0} | Type: {1}", group.Key.category, group.Key.type));
                foreach (var name in group)
                {
                    Console.WriteLine(string.Format("\tProduct Name: {0} | Type: {1}", name.productName, name.type));
                }
            }

            Console.ReadKey();


        }
    }
}