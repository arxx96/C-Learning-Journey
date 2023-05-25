using Day8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public abstract class Animal {
        //public string Name;
        //public int age;
        public string Name { get; set; }
        public int age { get; set; }

        //polymorphism
        public virtual void  move() {
            Console.WriteLine($"{Name} is moving");
        }
        public abstract void makesound();
        

    }
     class CAT : Animal {
        public string gender;

        public override string ToString()
        {
            return $"My name is {this.Name}";
        }

        //polymorphism
        public override void move()
        {
            base.move();
            Console.WriteLine("four legs");
        }
        public void sound()
        {
            Console.WriteLine("Meow");
        }

        public override void makesound()
        {
            Console.WriteLine($"{Name} is make sound");
        }
    }

    //Eagle class prevent  inherit >Sealed
    sealed public class  Eagle: Animal {
        public void flay()
        {
            Console.WriteLine("yes");
        }

        public override void makesound()
        {
            Console.WriteLine($"{Name} is make sound");
        }
    }
    class Dog : Animal
{
        public void category()
        {
            Console.WriteLine("aaaa");
        }

        public override void makesound()
        {
            Console.WriteLine($"{Name} is make sound");
        }
    }





}




