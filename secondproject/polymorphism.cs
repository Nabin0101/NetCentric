using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondproject
{
    internal class polymorphism
    {

        //static  polymorphsim//
        public void WhoAmI()
        {
            Console.WriteLine("I am empty Function");
        }
        public void WhoAmI(String name)
        {
            Console.WriteLine("I am " + name);
        }
        public void WhoAmI(int myRollNumber)
        {
            Console.WriteLine("My Roll no is: " + myRollNumber);
        }
    }
}
