using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class person
    {

        public int id;
        public string fName;
        public string lName;
        public int age;
        public string job;
        public string address;
        public bool isMarrid;

        public  person(int id,string fName, string lName, int age, string job, string address, bool isMarrid) {
            this.id = id;
            this.fName = fName;
            this.lName = lName;
            this.age = age;
            this.job = job;
            this.address = address;
            this.isMarrid = isMarrid;

        
        }


    }
}
