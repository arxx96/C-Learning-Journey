namespace indexr
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Using in Main 


            PhoneBook phone =new PhoneBook(2);
            phone[0, "arwa"] = "95678351";
            phone[1, "Safiya"] = "98745624";
            Console.WriteLine(phone.GetValue("Safiya"));




        }
    }
}