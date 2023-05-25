namespace SetGet
{
    internal class Program

    {

        static void Main(string[] args)
        {
            phoneBook pb = new phoneBook(8);
            pb.SetValue(0, "aaa", "2868");
            pb.GetValue("aaa");
            Console.WriteLine(pb.GetValue("aaa"));








        }
    }
}