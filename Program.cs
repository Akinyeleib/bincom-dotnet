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
        int [] numbers = {2, 4, 6, 8, 10};

        // 1. Sum
        int sum = 0;
        foreach (int i in numbers) {
            sum += i;
        }
        Console.WriteLine("Sum is: {0}", sum);

        // 2. Display
        Console.WriteLine("Elements in the array: ");
        foreach (int number in numbers) {
            Console.WriteLine(number);
        }

        // Task 5

        Greet("Alice");

    }

    static void Greet(String name) {
        Console.WriteLine("Hello, {0}!", name);
    }

}

