namespace FaviroteBookIndexer
{
    internal class Program
    {
        //indexer
        //when enter the book name it will return the author name
        static void Main(string[] args)
        {
         
            faviroteBook fBook=new faviroteBook(3);
            fBook[0, "book1"] = "arwa";
            fBook[1, "book2"] = "shrooq";
            fBook[2, "book3"] = "alaina";

            Console.WriteLine(fBook["book1"]);
            Console.WriteLine(fBook["book2"]);
            Console.WriteLine(fBook["book3"]);

        }
    }



    


}