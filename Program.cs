// See https://aka.ms/new-console-template for more information
using System;
using System.IO.Pipes;
using System.Xml.Serialization;

class MyClass
{
    static void TableGenerator()
    {
        Console.Write("Enter number = ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine($"{num} * {i} = " + (num * i));

        }
        Console.WriteLine("\n\n");

    }

    static void EvenOrOdd()
    {
        Console.Write("Enter number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine($"\n\n {num} is even.\n\n");
        }
        else
        {
            Console.WriteLine($"\n\n {num} is odd.\n\n");
        }
    }

    static void MaxFinder()
    {
        Console.Write("Enter number 1 : ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 2 : ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number 3 : ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        int max = num1;
        if (num2 > max)
        {
            max = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }

        Console.WriteLine("Maximum number is = " + max + "\n\n");
    }

    static void SumofN()
    {
        Console.Write("Enter number = ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= num; i++)
        {
            sum += i;
        }
        Console.WriteLine($"Sum till {num} is : " + sum + "\n\n");
    }

    static void ReversedNumber()
    {
        Console.Write("Enter number : ");
        int num = Convert.ToInt32(Console.ReadLine());
        int reversed = 0;
        int real = num;

        while (num != 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }

        Console.WriteLine($"reverse of {real} is : " + reversed + "\n\n");
    }

    static void Main(string[] args)
    {
        while (true)
        {


            Console.WriteLine("Enter 0 to exit program.");
            Console.WriteLine("Enter 1 for Multiplication Generator.");
            Console.WriteLine("Enter 2 for Even or Odd checker.");
            Console.WriteLine("Enter 3 for maximum of thee number finder.");
            Console.WriteLine("Enter 4 for Sum of First N Numbers.");
            Console.WriteLine("Enter 5 to Reverse a Number.");
            Console.WriteLine("Enter 6 for Factorial Calculator.");
            Console.WriteLine("Enter 7 for Leap Year Validator.");
            Console.WriteLine("Enter 8 for Fibonacci Series Printer.");
            Console.WriteLine("Enter 9 for Prime Number Checker.");
            Console.WriteLine("Enter 10 for GCD Finder.");
            Console.WriteLine("Enter 11 for Simple Calculator.");
            Console.WriteLine("Enter 12 for Digit Counter.");
            Console.WriteLine("Enter 13 for Palindrome Number.");
            Console.WriteLine("Enter 14 for Sum of Digits.");
            Console.WriteLine("Enter 15 for Armstrong Number Validator.");
            Console.WriteLine("Enter 16 for Max & Min in Array.");
            Console.WriteLine("Enter 17 for Linear Search.");
            Console.WriteLine("Enter 18 for Array Sort (Ascending).");
            Console.WriteLine("Enter 19 for Even/Odd Counter in Array.");
            Console.WriteLine("Enter 20 for Sort List of Names Alphabetically.");
            Console.WriteLine("Enter 21 for Frequency Counter (Array).");
            Console.WriteLine("Enter 22 for Matrix Addition.");
            Console.WriteLine("Enter 23 for Vowel Counter in String.");
            Console.WriteLine("Enter 24 for String Palindrome.");
            Console.WriteLine("Enter 25 for reversing Words in a Sentence.");
            Console.WriteLine("Enter 26 for Removing Duplicates from Array.");
            Console.WriteLine("Enter 27 for Student Marks Manager.");
            Console.WriteLine("Enter 28 for Patient Visit Console App.");
            Console.WriteLine("Enter 29 for Word Frequency Counter.");
            Console.WriteLine("Enter 30 for Random Password Generator.");


            Console.Write("\n\nEnter number of your choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 0)
            {
                Console.WriteLine("\n\n......You have exited the program....");
                break;
            }
            else if (choice > 30 || choice < 0)
            {
                Console.Write("Enter choice between 0-30 : ");
                choice = Convert.ToInt32(Console.ReadLine());
            }

            switch (choice)
            {
                case 1:
                    TableGenerator();
                    break;
                case 2:
                    EvenOrOdd();
                    break;
                case 3:
                    MaxFinder();
                    break;
                case 4:
                    SumofN();
                    break;
                case 5:
                    ReversedNumber();
                    break;
            }


        }


    }
}