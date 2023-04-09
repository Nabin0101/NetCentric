using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject
{
    internal class Program
    {
        static void Main(String[] args)
        {
            person obj = new person("Nabin", 2, "Nala");
            obj.NoOfEyes = 2;
            obj.Name = "Nabin";
            obj.address = "Nala";
            obj.Desc();
            Console.Read();

        }
    }
}
/*            datatypes in  C#//
            float f = 29;
            program for bool datatypes//

           Console.WriteLine("Do you want  to quit?");
           char a = Console.ReadLine()[0];
            bool quit = false;
            if (a == 'A')
            {
                quit = true;
            }
            if (quit == false)
            {
                Console.ReadKey();
            }
 */
/* Console.WriteLine("Hello Banepa");
 String hello = Console.ReadLine();
 //Console.Clear();
 Console.WriteLine("Enter two numbers");
 int firstNumber =Convert.ToInt32(Console.ReadLine());
 int secondNumber = Convert.ToInt32(Console.ReadLine());
 int sum = firstNumber + secondNumber;
 Console.WriteLine("Sum of two number is "+sum);
 Console.ReadKey();
}
}
}
/*

// string//
/* string myname = "Nabin Dahal";
            Console.WriteLine(myname);
            string hello = "Hi Computer 15";
            Console.WriteLine(hello.ToUpper());
            Console.WriteLine(hello.ToLower());

            Console.ReadKey();*/


// switch case//
/*Console.WriteLine("Enter you fav color");
String color=Console.ReadLine();
switch(color)
{
case "red":
  Console.WriteLine("You are lovely");
break;
case "blue":
Console.WriteLine("You are sky lover");
break;
case "green":
Console.WriteLine("You are nature lover");
break;
default:
Console.WriteLine("Error");
break;
}
Console.ReadKey();
*/
//looping
/*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("I am computer:"+i);
            }
            //Whileloop
            int counter = 1;
            while (counter < 5)
            {
                Console.WriteLine("Hello Computer15");
                counter += 2;
            }
            Console.ReadKey();
*/
// making objects //


/*
 *  static void Main(string[] args)
        {
            //Inheritance//
            Driver hari = new Driver();
            Student Nabin = new Student("Nabin", 3, "Nala");
            hari.Desc();
            Nabin.Desc();

            Console.ReadKey();

 */
