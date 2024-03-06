/*
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

*/
// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
string str = Console.ReadLine();

Console.WriteLine(3 + 3);

Console.WriteLine(str);
// */
// int intValue = 10;
// double doubleValue =32.32D;
// float floatValue = 3223.22F;
// bool boolVaue = true;
// //  int a =20;
//  string myText="!true";
//  bool k = Convert.ToBoolean(myText);
// // char letter ='s';
// // int a = 12;
// // a =14;
// Console.WriteLine(k);
// int testCase = 5;
// do
// {
//     Console.WriteLine("Enter your rating between 1 and 5");
//     int value = Convert.ToInt32(Console.ReadLine());
//     Console.Write("you choose ");
//     switch (value)
//     {
//         default:
//             Console.WriteLine("kaam kro");
//             break;
//         case 1:
//             Console.WriteLine("wrost rating");
//             break;
//         case 2:
//             Console.WriteLine("Bad rating");
//             break;
//         case 3:
//             Console.WriteLine("okay okay");
//             break;
//         case 4:
//             Console.WriteLine("good");
//             break;
//         case 5:
//             Console.WriteLine("Best");
//             break;
//         case 9:
//             Console.WriteLine("bye bye");
//             testCase=-1;
//             break;
//             // default:
//             //     Console.WriteLine("kaam kro");
//             //     break;
//     }
// }
// while (testCase-- > 0);
// int printTriangle =5;
// for(int i =0;i<printTriangle;i++)
// {
//     for(int k =0;k<i;k++)
//     {
//         Console.Write(" ");
//     }
//     for(int j=0;j<=printTriangle;j++)
//     {
//         Console.Write("*");
//         Console.Write(" ");
//     }
//     Console.WriteLine();
// }

//  int [] arr = new int [5];
//  foreach(int val in arr){
//     Console.Write($"{val} ");
//  }
//  Console.WriteLine();
// // for(int i=0;i<arr.Length;i++)
// // {
// //     arr[i]=i*2 + i%2;
// // }
// // foreach(int val in arr)
// // {
// //     Console.Write($"{val} ");
// // }
// string [] strArr = new string[7];
// foreach(string val in strArr)
// {
//     Console.Write($"{val} ");
// }
// Console.WriteLine();
// for(int i=0;i<strArr.Length;i++)
// {
//     if(i==3)
//     {
//         continue;
//     }
//     strArr[i]=Convert.ToString(i*2 + i%2);
// }
// foreach(string val in strArr)
// {
//     Console.Write($"{val} ");
// // }
// string [] arr ;
// arr={"a","b","c"};
// arr[3]="s";

// int [] arr = new int []{1,3,63,256,2,1,3,542,7,214,52,4};
// foreach(int val in arr)
// {
//     Console.Write($"{val} ");
// }
// Console.WriteLine();

// Array.Sort(arr);
// foreach(int val in arr)
// {
//     Console.Write($"{val} ");
// }
// Console.WriteLine();
// Console.WriteLine(arr.Max());
// int[,] numbers = { {1, 4, 2}, {3, 6, 8} };

// foreach (int i in numbers)
// {
//   Console.WriteLine(i);
// } 
// int [,] arr =
// {
//     {1,3,5},
//     {23,2,32}
// };
// Console.WriteLine(arr.GetLength(3));
//Program2.Main();
// class PrintTriangle
// {
//     public string shapeName;
//     public int random;
//     public PrintTriangle(string shapeName, int random)
//     {
//         this.shapeName = shapeName;
//         this.random = random;
//     }
//     public static void Triangle(int val = 3)
//     {
//         for (int i = 0; i < val; i++)
//         {
//             for (int k = 0; k < i; k++)
//             {
//                 Console.Write(" ");
//             }
//             for (int j = 0; j <= val; j++)
//             {
//                 Console.Write("*");
//                 Console.Write(" ");
//             }
//             Console.WriteLine();
//         }
//     }
// }
// class Shape
// {

//     public static void Main(string[] args)
//     {

//         // PrintTriangle shape = new PrintTriangle("square", 5);
//         // PrintTriangle.Triangle(5);
//         // PrintTriangle.Triangle();
//         // Console.WriteLine(shape.random);
//         // Console.WriteLine(shape.shapeName);
//         Person person1 = new Person();
//         person1.Name = "vinay";
//         Console.WriteLine(person1.Name);
//     }
// }
// class Person
// {
//     private string name = " ";
//     public string Name
//     {
//         get { return name; }
//         set { name = value; }
//     }
// }




// sealed class Vehicle  // base class (parent) 
// {
//   public string brand = "Ford";  // Vehicle field
//   public void honk()             // Vehicle method 
//   {                    
//     Console.WriteLine("Tuut, tuut!");
//   }
// }

// class Car : Vehicle  // derived class (child)
// {
//   public string modelName = "Mustang";  // Car field
// }

// class Program
// {
//   static void Main(string[] args)
//   {
//     // Create a myCar object
//     Car myCar = new Car();

//     // Call the honk() method (From the Vehicle class) on the myCar object
//     myCar.honk();

//     // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
//     Console.WriteLine(myCar.brand + " " + myCar.modelName);
//   }
//}

// abstract class Animal
// {
//     // Abstract method (does not have a body)
//     public abstract void animalSound();
//     // Regular method
//     public void sleep()
//     {
//         Console.WriteLine("Zzz");
//     }
// }

// // Derived class (inherit from Animal)
// class Pig : Animal
// {
//     public new void sleep()
//     {
//         Console.WriteLine("pigzzzzz");
//     }
//     public override void animalSound()
//     {
//         // The body of animalSound() is provided here
//         Console.WriteLine("The pig says: wee wee");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Pig myPig = new Pig(); // Create a Pig object
//         myPig.animalSound();  // Call the abstract method
//         myPig.sleep();  // Call the regular method
//     }
// }
// interface Animal 
// {
//   void animlkalSound(); // interface method (does not have a body)
//   void run(); // interface method (does not have a body)
// }


// interface IFirstInterface 
// {
//   void myMethod(); // interface method
// }

// interface ISecondInterface 
// {
//   void myOtherMethod(); // interface method
// }

// // Implement multiple interfaces
// class DemoClass : IFirstInterface, ISecondInterface 
// {
//   public void myMethod() 
//   {
//     Console.WriteLine("Some text..");
//   }
//   public void myOtherMethod() 
//   {
//     Console.WriteLine("Some other text...");
//   }
// }

// class Program 
// {
//   static void Main(string[] args)
//   {
//     DemoClass myObj = new DemoClass();
//     myObj.myMethod();
//     myObj.myOtherMethod();
//   }


// static void checkAge(int age)
// {
//   if (age < 18)
//   {
//     throw new ArithmeticException("Access denied - You must be at least 18 years old.");
//   }
//   else
//   {
//     Console.WriteLine("Access granted - You are old enough!");
//   }
// }

// static void Main(string[] args)
// {
//   checkAge(15);
// }
// int d=12;
// }



//------------------------------------------------------------------
//Delegated
namespace file1
{
   class Opener
   {
      public static void Main(string[] args)
      {
         Publisher publisher = new Publisher();
         SomethingWillHappened sh = publisher.sum;
         sh += publisher.substract;
      }
   }
}
