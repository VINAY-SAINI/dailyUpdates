// using System;
// using System;
// namespace file1
// {
//     public delegate void SomethingWillHappened(int a, int b);

// public class Publisher : Subscriber
// {

//     public void sum(int a, int b)
//     {
//         Console.WriteLine($"the sum of {a} + {b} = {a + b}");
//     }
// }
// public class Subscriber
// {
//     public void substract(int a, int b)
//     {
//         Console.WriteLine($"the sum of { a} - {b} = {a - b}");
//     }
// }
// }

// public class Printer<T> where T : IComparable
// {
//     // Method to print the larger of two values
//     public void PrintLarger(T a, T b)
//     {
//         if (a.CompareTo(b) > 0)
//             Console.WriteLine($"Larger value: {a}");
//         else
//             Console.WriteLine($"Larger value: {b}");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Printer<int> intPrinter = new Printer<int>();
//         intPrinter.PrintLarger(10, 20); // Output: Larger value: 20

//         Printer<string> stringPrinter = new Printer<string>();
//         stringPrinter.PrintLarger("Apple", "Orange"); // Output: Larger value: Orange
//     }
// }


// // A generic class to represent a simple stack
// public class Stack<T>
// {
//     private T[] elements;
//     private int top;

//     public Stack(int capacity)
//     {
//         elements = new T[capacity];
//         top = -1;
//     }

//     public void Push(T item)
//     {
//         if (top == elements.Length - 1)
//         {
//             Console.WriteLine("Stack overflow");
//             return;
//         }
//         elements[++top] = item;
//     }

//     public T Pop()
//     {
//         if (top == -1)
//         {
//             Console.WriteLine("Stack underflow");
//             return default(T);
//         }
//         return elements[top--];
//     }

//     public void Display()
//     {
//         Console.WriteLine("Stack elements:");
//         for (int i = top; i >= 0; i--)
//         {
//             Console.WriteLine(elements[i]);
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Creating a stack of integers
//         Stack<int> intStack = new Stack<int>(5);
//         intStack.Push(10);
//         intStack.Push(20);
//         intStack.Push(30);
//         intStack.Display(); // Output: 30, 20, 10

//         // Creating a stack of strings
//         Stack<string> stringStack = new Stack<string>(3);
//         stringStack.Push("One");
//         stringStack.Push("Two");
//         stringStack.Push("Three");
//         stringStack.Display(); // Output: Three, Two, One
//     }
// }
