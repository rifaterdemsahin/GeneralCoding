using System;
using System.Collections.Generic;
using System.Linq;

namespace GeneralCodingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🚀 Welcome to General Coding C# Examples!");
            Console.WriteLine("=========================================");
            
            // Basic data types and variables
            DemonstrateBasicTypes();
            
            // Collections and LINQ
            DemonstrateCollections();
            
            // Object-oriented programming
            DemonstrateOOP();
            
            // Exception handling
            DemonstrateExceptionHandling();
            
            // Async/await pattern
            DemonstrateAsync().Wait();
            
            Console.WriteLine("\n✅ All examples completed successfully!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        static void DemonstrateBasicTypes()
        {
            Console.WriteLine("\n📊 Basic Data Types:");
            
            int number = 42;
            double price = 19.99;
            string message = "Hello, C#!";
            bool isActive = true;
            
            Console.WriteLine($"Integer: {number}");
            Console.WriteLine($"Double: {price:C}");
            Console.WriteLine($"String: {message}");
            Console.WriteLine($"Boolean: {isActive}");
        }
        
        static void DemonstrateCollections()
        {
            Console.WriteLine("\n📚 Collections and LINQ:");
            
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            var sum = numbers.Sum();
            var squares = numbers.Select(n => n * n).ToList();
            
            Console.WriteLine($"Original numbers: [{string.Join(", ", numbers)}]");
            Console.WriteLine($"Even numbers: [{string.Join(", ", evenNumbers)}]");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Squares: [{string.Join(", ", squares)}]");
        }
        
        static void DemonstrateOOP()
        {
            Console.WriteLine("\n🏗️ Object-Oriented Programming:");
            
            var person = new Person("Alice", 30);
            var developer = new Developer("Bob", 25, "C#");
            
            Console.WriteLine(person.GetInfo());
            Console.WriteLine(developer.GetInfo());
            Console.WriteLine($"Bob codes in: {developer.ProgrammingLanguage}");
        }
        
        static void DemonstrateExceptionHandling()
        {
            Console.WriteLine("\n⚠️ Exception Handling:");
            
            try
            {
                int result = 10 / 0;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Caught exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }
        
        static async System.Threading.Tasks.Task DemonstrateAsync()
        {
            Console.WriteLine("\n⏰ Async/Await Pattern:");
            
            Console.WriteLine("Starting async operation...");
            await SimulateAsyncWork();
            Console.WriteLine("Async operation completed!");
        }
        
        static async System.Threading.Tasks.Task SimulateAsyncWork()
        {
            await System.Threading.Tasks.Task.Delay(1000);
            Console.WriteLine("Simulated work completed after 1 second");
        }
    }
    
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        
        public virtual string GetInfo()
        {
            return $"Person: {Name}, Age: {Age}";
        }
    }
    
    public class Developer : Person
    {
        public string ProgrammingLanguage { get; set; }
        
        public Developer(string name, int age, string programmingLanguage) : base(name, age)
        {
            ProgrammingLanguage = programmingLanguage;
        }
        
        public override string GetInfo()
        {
            return $"Developer: {Name}, Age: {Age}, Language: {ProgrammingLanguage}";
        }
    }
}