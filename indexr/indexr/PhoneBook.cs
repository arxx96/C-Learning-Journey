using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexr
{
    internal class PhoneBook
    {
        private string[] names;
        private string[] numbers;
        private int Size;

        public PhoneBook(int size)
        {
            this.Size = size;
            this.names = new string[this.Size];
            this.numbers = new string[this.Size];

        }



        //indexr
        public string this[int index, string name]
        {

            get
            {

                for (int i = 0; i < this.Size; i++)
                {
                    if (this.names[i] == name)
                    {
                        return numbers[i];
                    }

                }
                return "falid";
            }
            set
            {
                numbers[index] = value;
                this.names[index] = name;

            }


        }

        public string this[string name]
        {

            get
            {

                for (int i = 0; i < this.Size; i++)
                {
                    if (this.names[i] == name)
                    {
                        return this.numbers[i];
                    }

                }
                return "falid";
            }



        }



        public void SetValue(int index, string name, string num)
        {

            if ((index > 0) && (index < Size))
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
