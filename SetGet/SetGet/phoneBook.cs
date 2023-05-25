using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetGet
{
    internal class phoneBook
    {
        private string[] names;
        private string[] numbers;
        private int Size;
      
        public phoneBook(int size) {
            this.Size = size;
        this.names = new string[this.Size];
          this.numbers = new string[this.Size];
       
        }

        public void SetValue(int index, string name, string num) {

            if ((index>0)&& (index < Size))
            {

                this.names[index] = name;
                this.numbers[index] = num;  
            }

        }
        public string GetValue(string name)

        {


            for (int i = 0; i < name.Length; i++)
            {
                if (names[i] == name)
                {
                    return this.numbers[i];
                }


            }
            return "faild";

        }


    }
}
//for (int i = 0; i < this.Size; i++) {

//    Console.WriteLine("Enter your name");
//    name[i] = Console.ReadLine();

//    Console.WriteLine("Enter your name");
//    num[i] = Console.ReadLine();



//}

//Console.WriteLine("Enter the size: ");
//int length = Console.ReadLine();
// phoneBook pb = new phoneBook(length);