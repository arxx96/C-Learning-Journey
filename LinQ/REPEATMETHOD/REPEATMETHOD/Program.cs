namespace REPEATMETHOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> repeatNumber = Enumerable.Repeat(5, 10);
            foreach (var num in repeatNumber)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}