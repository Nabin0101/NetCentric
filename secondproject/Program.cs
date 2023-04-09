using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondproject
{
    internal class program
    {
        static void Main(String[] args) { 

        //Error Handling//
        try
{
  String[] names = new string[5];
        names[0] = "Nabin";
//stack expection//
names[5] = "Computer";
String myNum = Console.ReadLine();
        int rollNum = Convert.ToInt32(myNum);
        Console.WriteLine(rollNum);
}
catch(Exception ex)
{
    Console.WriteLine("Exception occur of " + ex.Message);
}
Console.Read();
}
}
}
/*Interface
static void Main(string[] args)
        {
            Lion l1 = new Lion();
            l1.WhatIEat();
            l1.WhatIBreathe();
            Console.Read();
        }
    }
}*/
//Dyanmic polymorphism//
/* static void Main(string[] args)
{
 Tiger tg= new Tiger();
 tg.WhatIEat();
 tg.WhatIBreathe();
 Console.Read();
}
}
}
*/

//hello//
//Function overloading or static polymorphism
//static void Main(string[] args)
//{
//  polymorphism poly = new polymorphism();
//poly.WhoAmI();
//poly.WhoAmI("nabin");
//poly.WhoAmI(6);
//Console.ReadKey();
//}

//Indexers//
//Error Handling//


