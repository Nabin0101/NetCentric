using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdproject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array List//
            ArrayList al = new ArrayList();
            al.Add("Nabin");
            al.Add(123);
            al.Add(true);
            Console.WriteLine(al);
            Console.Read();

            //link //
            List<string> list = new List<string>();
            list.Add("Helllo");
            Console.WriteLine(list);
            Console.Read();
        }
    }
}
//Asynchronous and sync
/* static void Main(string[] args)
 {
     MyFun2();
     MyFun1();
     Console.Read();
 }
 public static void MyFun1()
 {
     for (int counter = 1; counter <= 6; counter++)
     {
         Console.WriteLine("Hi Nist Family");
     }
 }
 public static async void MyFun2()
 {
     await Task.Run(() =>
      {
          for (int counter = 1; counter <= 6; counter++)
          {
              Console.WriteLine("I am Nistian");
          }
      });
 }
}
}

 // File handling//
// static void Main(string[] args)
 //{
     /*Writing in file//
     StreamWriter sw = new StreamWriter("Nist.txt");
     sw.WriteLine("We are learning C# in this college");
     sw.WriteLine("First chapter is already completed!!");
     sw.Close();
 }*/


//Reading from file//
/*StreamReader sr = new StreamReader("Nist.txt");
string line = sr.ReadLine();
while (line != null)
{
    Console.WriteLine(line);
    line = sr.ReadLine();
}
Console.Read();
}
}
}

//Delegates//
/*public delegate void function1caller();
static void Main(string[] args)
{
//different delegate//
function1caller fn = new function1caller(MyFun1);
function1caller fn1 = new function1caller(MyFun2);
fn();
fn1();
Console.Read();
}
// Same delegate//
function1caller fn = new function1caller(MyFun1);
fn += MyFun2;// delegate ma  a+=b matra garna paiyo not a=a+b//
fn();
Console.ReadKey();
}
public static void MyFun1()
{
for (int counter = 1; counter <= 5; counter++)
{
Console.WriteLine("I am computer 15");
}
}
public static void MyFun2()
{
for (int counter = 1; counter <= 5; counter++)
{
Console.WriteLine("I am User of Comp_15");
}
}



Console.ReadKey();
}*/

