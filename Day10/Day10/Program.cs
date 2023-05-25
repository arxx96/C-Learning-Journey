using System.Security.Cryptography.X509Certificates;

namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // MasterCard masterCard=new MasterCard(239m);
           // masterCard.Pay();

            Cashier cash = new Cashier(new cash(999982));
            cash.Checkout();




        }
    }
}