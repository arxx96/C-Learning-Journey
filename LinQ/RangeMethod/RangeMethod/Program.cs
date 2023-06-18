namespace RangeMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> squareNumber = Enumerable.Range(2, 4).Select(x => x * x);
            foreach (var num in squareNumber)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}