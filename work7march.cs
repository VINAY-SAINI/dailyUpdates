using System;

namespace MyProject
{


    class A :B
    {
        //public event EventHandler OnEventDelegate;
        public void fun1(int a, int b)
        {
            Console.WriteLine($"the value of sum of  and ");
        }

        public void fun2(int a, int b)
        {
            Console.WriteLine($"the value of subtraction of {a} and {b} is {a - b}");
        }
    }

    class B
    {
        public static void fun3(int a, int b)
        {
            Console.WriteLine($"the value of multiplication of {a} and {b} is {a * b}");
        }

        public static void fun4(int a, int b)
        {
            Console.WriteLine($"the value of power of {a} and {b} is {Math.Pow(a, b)}");
        }
    }

    // class C
    // {
    //     public static void Play()
    //     {
         
    //     }
    // }
}
