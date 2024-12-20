using System;

namespace home14
{
    class Animal
    {
        public string Name = "Sher";
        public string Type = "Mard";
        public int Age = 12;
        
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Type: {Type}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            Console.WriteLine($"Animal Name: {animal.Name}");
            Console.WriteLine($"Animal Type: {animal.Type}");
            Console.WriteLine($"Animal Age: {animal.Age}");

            animal.PrintInfo();
        }
    }
}
