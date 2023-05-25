namespace Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            CAT cAT = new CAT();
            cAT.Name = "vlavi";
            cAT.move();
            Console.WriteLine(cAT);


            Eagle eagle = new Eagle();
            Dog dog = new Dog();
            dog.move();
            eagle.move();




            vehicle veh = new honda(2, "aaaa", "gggg", 2019);
            honda  honda1=new honda(1,"honda","new",2023);

            caterpilar cat=new caterpilar(2,"eee","tttt");
            cat.move();
            cat.stop();
            cat.loud();
            cat.unloud();



            





        }
    }
}