using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaviroteBookIndexer
{

    //class faviroteBook contain  > BookName,AuthorName, index
    internal class faviroteBook
    {  
            private string[] BookName;
            private string[] AuthorName;
            private int index;

        // ctor 
        //constructor 
        public faviroteBook(int index)
        {
            this.index = index;
            this.BookName=new string[index];
            this.AuthorName = new string[index];
            
        }
        //indexer
        public string this[int len, string BN]
        {
            set
            {
                BookName[len] = BN;
                AuthorName[len] = value;
            }
            get
            {
                string res = $"the book name is {BN} the author is {AuthorName[len]}";
                return res;
            }
        }
        //indexer to search for book name
        public string this[string Bookname]
        {
            get
            {
                for (int i = 0; i < BookName.Length; i++)

                {
                    if (this.BookName[i] == Bookname)

                        return "book name: " + this.BookName[i] + "  author:  " + this.AuthorName[i];
                }

                return "!!!!!!";

            }

        }
    }
}
