namespace EMPTYMETHOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emptyNumber = Enumerable.Empty<string>();
            foreach (var num in emptyNumber)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}