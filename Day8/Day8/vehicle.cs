using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class vehicle { 
        public int id;  
        public string name;
        public string description;

        public vehicle(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

    }

    interface IDriveable
    {
        void move();
        void stop();
            
    }
    interface ILoud { 
        void move();
    void loud();
        void unloud();
        

    }

    class honda: vehicle , IDriveable { 
        public int yearOfManfucteuer;
        public honda  (int id, string name, string description, int yearOfManfucteuer):base(id, name, description)
        {
            
             this.yearOfManfucteuer = yearOfManfucteuer;
        }
        public void move()
        {
            Console.WriteLine("is moving");
        }
        public void stop()

        { Console.WriteLine("stop"); }
    
    }
       

    class caterpilar: vehicle, IDriveable, ILoud 
    {
        public caterpilar(int id, string name, string description) : base(id, name, description)
        {
        }
            
            public void loud()
            {
                Console.WriteLine("loud");
            }

            public void move()
            {
                Console.WriteLine("move");
            }

            public void stop()
            {
                Console.WriteLine("stop");
            }

            public void unloud()
            {
                Console.WriteLine("unload");
            }


         void ILoud.move() { 
            Console.WriteLine("move"); 
        }
       
            
        }


    }



   

