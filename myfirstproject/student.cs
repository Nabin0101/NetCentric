using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject
{
    public class Student : person
    {
        public  Student (string Name, int NoOfEyes ,string address):base( Name, NoOfEyes, address){

        }
        public  void Desc() { Console.WriteLine("I am student:");
            base.Desc();
        }
    }
}

