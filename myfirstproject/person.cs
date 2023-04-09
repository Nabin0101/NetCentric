using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace myfirstproject
{
    // Inheritance//

    public class person

    {
        public person() { }
        //OOP properties//
        public int NoOfEyes { get; set; }//get and set are accessor
        public string address { get; set; }
        public string Name { get; set; }

        public  virtual void Lunch()
     {
         Console.WriteLine("I usually dont have lunch:");
     }
        //constructor//
        public person(string nam, int noeye, string add)
        {
            this.Name = nam;
            this.NoOfEyes = noeye;
            this.address = add;
        }
        public void Desc()
        {
            Console.WriteLine("My name is " + Name);
            Console.WriteLine("My Address is " + address);
            Console.WriteLine("I have " + NoOfEyes + "eyes");

            Console.ReadKey();
        }



    }

}
