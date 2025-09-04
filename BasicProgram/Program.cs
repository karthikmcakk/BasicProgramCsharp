// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using BasicProgram.Models;
using System;
namespace BasicPrgramApp
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to myworld");
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Name is: {name}");
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Age is : {age}");
            Console.WriteLine("Favourite programing language is:");
            string language = Console.ReadLine();
            Console.WriteLine($"Progamming language is {language}");
            Console.WriteLine("Enter the value :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Add : {a + b}");
            Console.WriteLine($"Multiply : {a * b}");


            Console.WriteLine("");
            Person person = new Person();

            Console.WriteLine("Enter the Name:");
            person.Name = Console.ReadLine();
            Console.WriteLine("Enter the Age:");
            person.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Name is {person.Name}");
            Console.WriteLine($"Age is {person.Age}");

        }
    }
}



