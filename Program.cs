using System;

class Program
{
    static void Main(string [] args) {
        // Task 1

        string name = "John Doe";

        int age = 25;

        bool isAdmin = true;

        Console.WriteLine(name);
        Console.WriteLine(age);
        Console.WriteLine(isAdmin);


        // Task 2


        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0) {
            Console.WriteLine("Even");
        }
        else {
            Console.WriteLine("Odd");
        }

        // Task 3
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Task 4


        // Task 5

        Greet("Alice");

    }

    static void Greet(String name) {
        Console.WriteLine("Hello, {0}!", name);
    }

}

