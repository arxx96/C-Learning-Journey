using static DelegateRectangle.RectangleHelp;

namespace DelegateRectangle
{
    
    
    
    
    internal class Program
    {



        static void Main(string[] args)
        {


            //new object of the main class
            RectangleHelp rectangle = new RectangleHelp();

            //new object of the delegate
            //inside delegate (main class object , method)
            Rectanglee rec= new Rectanglee(rectangle.getArea);
            
            // delegate += main class object.methods
            //multicast delegate
            //subscribe +=
            rec += rectangle.getParmeter;
            rec += rectangle.Sub;
            rec += rectangle.add;
            rec(12, 18);
            //unsubscribe -=
           








        }
    }


    internal class RectangleHelp
    {



        //delegate , withoutbody
        public delegate void Rectanglee(double width, double highet);



        public double width { get; set; }
        public double height { get; set; }


        public void getArea(double width, double height)
        {
            Console.WriteLine($"getArea  {width * height}");
        }



        public void getParmeter(double width, double height)
        {
            Console.WriteLine($"getParmeter {2 * (width + height)}");
        }

        public void add(double width, double height)
        {
            Console.WriteLine($"add {width + height}");
        }

        public void Sub(double width, double height)
        {
            Console.WriteLine($"Sub  {width - height}");
        }


    }




}