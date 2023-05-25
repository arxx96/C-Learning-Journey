namespace day7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            Person P1 = new Person();
            P1.SetfirstName("Ahmed");
            P1.SetlastName("said");
            P1.Setage(1988);
            P1.Setsalary(900);
            Console.WriteLine(P1.printInfo());

            BankAccount BA = new BankAccount();
             BA.SetaccountNo(1234);
            BA.SetaBalance(1400);
            BA.deposite(600);
            BA.withdrow(200);
            
           
         
           



        }
    }
}