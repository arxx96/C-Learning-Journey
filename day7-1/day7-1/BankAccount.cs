using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day7_1
{
    internal class BankAccount
    {

        private const decimal MaxAmount = 1000;
        private int accountNo;
        private  decimal Balance ;

        public void SetaccountNo(int accountNo)
        {
            this.accountNo = accountNo;
        }
       
        public int GetaccountNo()
        {
            return accountNo;
        }

        public void SetaBalance(decimal Balance)
        {
            this.Balance = Balance;
        }
        public decimal GetBalance()
        {
            return Balance;
        }


        public decimal deposite( decimal Newdeposite) {
            Balance = Balance+ Newdeposite;
            return Balance;
        }
        public decimal withdrow(decimal WD)
        {

            if (WD >= MaxAmount) {

                Console.WriteLine("these amount is not allowed");
            }
             if (WD > Balance) {
                Console.WriteLine("your  account is too low");
            }


            else  { 
            Balance = Balance - WD;
                Console.WriteLine($"your amount is {Balance}");


            }
            return Balance;

        }


    }
}
