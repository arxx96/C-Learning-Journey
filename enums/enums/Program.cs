namespace enums
{
    internal class Program
    {



        //Enum of days
        public enum Days
        {
            Sunday=1,
            Monday,
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday,

        }

        static void Main(string[] args)
        {

            //Creating instance of enum

                        Days days = Days.Tuesday;
            Console.WriteLine((int)days);


        }
    }
}