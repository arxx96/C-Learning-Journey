using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class Cashier
    {

        //use Ipayment interface
        public Ipayment Ipayment { get; set; }

        //constructor 
        public Cashier(Ipayment Ipayment) {
            this.Ipayment = Ipayment;

        }

        public void Checkout()
        {
            Ipayment.Pay();
        }
}
    interface Ipayment{
           void Pay();
}
    // inheritance
    class cash : Ipayment
    {
        public decimal amount { get; set; }
        public cash(decimal amount) {
            this.amount=amount;
        
        }
        public void Pay()
        {
            Console.WriteLine(amount);
        }
    }
    class visa : Ipayment
    {
        public decimal amount { get; set; }
        public visa(decimal amount)
        {
            this.amount=amount;
        }
        public void Pay()
        {
            Console.WriteLine(amount);
        }
    }
    class MasterCard : Ipayment
    {
        public decimal amount { get; set; }
        public MasterCard(decimal amount)
        {
            this.amount=amount;
        }
        public void Pay()
        {
            Console.WriteLine(amount);
        }
    }














}
