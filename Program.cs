
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


using System;

class Program
{
    static void Main(string[] args)
    {
        // Syntax and Output Examples
        Console.WriteLine("Hello, World!");

        // User Input Example
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();
        Console.WriteLine("You entered: " + str);

        // Arithmetic Operations Example
        Console.WriteLine(3 + 3);

        // Variables and Data Types Examples
        int intValue = 10;
        double doubleValue = 32.32D;
        float floatValue = 3223.22F;
        bool boolValue = true;

        // Casting Examples
        doubleValue = intValue; // Implicit Casting
        intValue = (int)doubleValue; // Explicit Casting

        // Boolean Operations Example
        string myText = "true";
        bool k = Convert.ToBoolean(myText);
        Console.WriteLine(k);

        // Control Structures Examples
        // If-Else Example
        int rating;
        Console.WriteLine("Enter your rating between 1 and 5");
        rating = Convert.ToInt32(Console.ReadLine());
        Console.Write("You choose: ");
        switch (rating)
        {
            case 1:
                Console.WriteLine("Worst rating");
                break;
            case 2:
                Console.WriteLine("Bad rating");
                break;
            case 3:
                Console.WriteLine("Okay rating");
                break;
            case 4:
                Console.WriteLine("Good rating");
                break;
            case 5:
                Console.WriteLine("Best rating");
                break;
            default:
                Console.WriteLine("Invalid rating");
                break;
        }

        // Looping Structures Examples
        // For Loop Example
        int printTriangle = 5;
        for (int i = 0; i < printTriangle; i++)
        {
            for (int k = 0; k < i; k++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j <= printTriangle; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        // Arrays Examples
        // 1D Array Example
        int[] arr = new int[] { 1, 3, 63, 256, 2, 1, 3, 542, 7, 214, 52, 4 };
        Array.Sort(arr);
        foreach (int val in arr)
        {
            Console.Write($"{val} ");
        }
        Console.WriteLine();

        // 2D Array Example
        int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }

        // Classes and Objects Example
        // Creating a Person object
        Person person1 = new Person();
        person1.Name = "Vinay";
        Console.WriteLine(person1.Name);
    }
}

// Class representing a Person
class Person
{
    private string name = " "; // Field

    // Property for accessing and setting the name field
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        // More C# Topics Examples

        // Constants Example
        const int constantValue = 100;
        Console.WriteLine("Constant value: " + constantValue);

        // Break and Continue Example
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
                continue; // Skip printing 5
            Console.WriteLine(i);
            if (i == 7)
                break; // Exit loop at 7
        }

        // Multidimensional Array Example
        int[,] multiArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(multiArray[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Jagged Array Example
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };
        foreach (int[] row in jaggedArray)
        {
            foreach (int num in row)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        // Enum Example
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        Days today = Days.Wednesday;
        Console.WriteLine("Today is: " + today);

        // Exception Handling Example
        try
        {
            int[] numbers = { 1, 2, 3 };
            Console.WriteLine(numbers[5]); // Accessing out of bounds
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }

        // Abstract Class Example
        // Animal animal = new Animal(); // Cannot instantiate abstract class
        Dog dog = new Dog();
        dog.AnimalSound();

        // Interface Example
        Dog myDog = new Dog();
        myDog.AnimalSound();
        myDog.Run();
    }
}

// Abstract Class Example
abstract class Animal
{
    public abstract void AnimalSound();
}

class Dog : Animal, IRunnable
{
    public override void AnimalSound()
    {
        Console.WriteLine("The dog says: Woof");
    }

    public void Run()
    {
        Console.WriteLine("The dog is running");
    }
}

// Interface Example
interface IRunnable
{
    void Run();
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // More C# Topics Examples

        // Properties Example
        Person person = new Person();
        person.Name = "John"; // Setting the name using the property
        Console.WriteLine("Name: " + person.Name); // Getting the name using the property

        // Static Members Example
        Console.WriteLine("Number of persons: " + Person.Count); // Accessing static member

        // Inheritance Example
        Student student = new Student();
        student.Name = "Alice";
        student.Age = 20;
        student.Display(); // Calling method from the base class

        // Polymorphism Example
        Animal animal;
        animal = new Dog();
        animal.MakeSound(); // Calls the method from Dog class
        animal = new Cat();
        animal.MakeSound(); // Calls the method from Cat class

        // Constructor Overloading Example
        Employee employee1 = new Employee(); // Using default constructor
        Employee employee2 = new Employee("John", 30); // Using parameterized constructor

        // Method Overriding Example
        Shape shape = new Rectangle();
        shape.Draw(); // Calls the Draw method of Rectangle class
        shape = new Circle();
        shape.Draw(); // Calls the Draw method of Circle class
    }
}

// Properties Example
class Person
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

// Static Members Example
class Person
{
    public static int Count = 0;

    public Person()
    {
        Count++; // Increment count for each object created
    }
}

// Inheritance Example
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Student : Person
{
    // Inherits Name and Age properties and Display method
}

// Polymorphism Example
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}

// Constructor Overloading Example
class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Employee()
    {
        Console.WriteLine("Default constructor called");
    }

    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine("Parameterized constructor called");
    }
}

// Method Overriding Example
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing shape");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing rectangle");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing circle");
    }
}



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
