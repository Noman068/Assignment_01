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
        int original = num;

        while (num != 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }

        Console.WriteLine($"reverse of {original} is : " + reversed + "\n\n");
    }

    static void Factorial()
    {
        Console.Write("Enter number : ");
        int num= Convert.ToInt32(Console.ReadLine());
        int factorial = 1;
        for(int i = num; i > 1; i--)
        {
            factorial *= i;
        }
        Console.WriteLine($"Factorial of {num} is = " + factorial + "\n\n");
    }

    static void LeapYear()
    {
        Console.Write("Enter year : ");
        int year = Convert.ToInt32(Console.ReadLine());
        if ((year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0)))
        {
            Console.WriteLine($"\n\n {year} is a leap year..\n\n");
        }
        else
        {
            Console.WriteLine($"\n\n {year} is not a leap year.\n\n");
        }
    }

    static void FibonacciSeries()
    {
       Console.Write("Enter number : ");
        int n = Convert.ToInt32(Console.ReadLine());
        int a = 0, b = 1, c;

        Console.WriteLine("Fibonacci Series:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
        Console.WriteLine("\n\n");
    }

    static void PrimeNumberChecker()
    {
        Console.Write("Enter number to check if it's prime: ");
        int num = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;

        if (num <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        Console.WriteLine(isPrime ? $"{num} is a prime number." : $"{num} is not a prime number.\n\n");
    }

    static void GCD()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        Console.WriteLine($"GCD is: {a}\n\n");
    }

    static void SimpleCalculator()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter operator (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());
        Console.WriteLine();

        double result = 0;
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                { result = num1 / num2;
                    break; }
                else
                    Console.WriteLine("Cannot divide by zero.");
                return;
            default:
                Console.WriteLine("Invalid operator.");
                return;
        }

        Console.WriteLine("Result :"+ result+"\n\n");
    }

    static void DigitCounter()
    {
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int count = 0;

        while (num != 0)
        {
            num /= 10;
            count++;
        }

        Console.WriteLine($"Number of digits: {count}\n\n");
    }

    static void PalindromeNumber()
    {
        Console.Write("Enter number to check if it's a palindrome: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int original = num;
        int reversed = 0;

        while (num != 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }

        Console.WriteLine(original == reversed ? $"{original} is a palindrome." : $"{original} is not a palindrome.\n\n");
    }

    static void SumOfDigits()
    {
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }

        Console.WriteLine($"Sum of digits: {sum}\n\n");
    }

    static void CheckArmstrong()
{
    Console.Write("Enter any positive integer: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int original = number;

    
    int digits = 0;
    int temp = number;
    while (temp > 0)
    {
        digits++;
        temp /= 10;
    }

    
    int sum = 0;
    temp = number;
    while (temp > 0)
    {
        int digit = temp % 10;
        int power = 1;

        
        for (int i = 0; i < digits; i++)
            power *= digit;

        sum += power;
        temp /= 10;
    }

    // Result
    if (sum == original)
        Console.WriteLine($"{original} is an Armstrong number.\n");
    else
        Console.WriteLine($"{original} is not an Armstrong number.\n");
}


    static void MaxMinInArray()
    {
        Console.Write("Enter number of elements in array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int max = arr[0], min = arr[0];
        foreach (int num in arr)
        {
            if (num > max) max = num;
            if (num < min) min = num;
        }

        Console.WriteLine($"Max: {max}, Min: {min}\n\n");
    }

    static void LinearSearch()
    {
        Console.Write("Enter number of elements in array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter element to search: ");
        int target = Convert.ToInt32(Console.ReadLine());
        bool found = false;

        for (int i = 0; i < n; i++)
        {
            if (arr[i] == target)
            {
                Console.WriteLine($"Element {target} found at index {i}.\n\n");
                found = true;
                break;
            }
        }

        if (!found)
            Console.WriteLine($"Element {target} not found in the array.\n\n");
    }

    static void ArraySortAscending()
    {
        Console.Write("Enter number of elements in array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(arr);
        Console.WriteLine("Sorted array in ascending order: " + string.Join(", ", arr) + "\n\n");
    }

    static void EvenOddCounterInArray()
    {
        Console.Write("Enter number of elements in array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int evenCount = 0, oddCount = 0;
        foreach (int num in arr)
        {
            if (num % 2 == 0) evenCount++;
            else oddCount++;
        }

        Console.WriteLine($"Even count: {evenCount}, Odd count: {oddCount}\n\n");
    }

   static void SortListOfNames()
{
    Console.Write("Enter number of names: ");
    int n = Convert.ToInt32(Console.ReadLine());

    List<string> names = new List<string>();

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Name {i + 1}: ");
        string input = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Name cannot be empty. Please enter a valid name.");
            Console.Write($"Name {i + 1}: ");
            input = Console.ReadLine();
        }
        names.Add(input);
    }

    names.Sort();
    Console.WriteLine("Sorted names: " + string.Join(", ", names) + "\n\n");
}

    static void FrequencyCounter()
    {
        Console.Write("Enter number of elements in array: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        var frequency = new Dictionary<int, int>();
        foreach (var num in arr)
        {
            if (frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }

        Console.WriteLine("Frequency of elements:");
        foreach (var kvp in frequency)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
        Console.WriteLine("\n\n");
    }

    static void MatrixAddition()
    {
        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix1 = new int[rows, cols];
        int[,] matrix2 = new int[rows, cols];
        int[,] result = new int[rows, cols];

        Console.WriteLine("Enter elements of first matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Element [{i+1},{j+1}]: ");
                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter elements of second matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            { 
                Console.Write($"Element [{i+1},{j+1}]: ");
                matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        Console.WriteLine("Resultant matrix after addition:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n\n");
    }

    static void VowelCounterInString()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        int count = 0;

        foreach (char c in input.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                count++;
            }
        }

        Console.WriteLine($"Number of vowels in the string: {count}\n\n");
    }   

    static void StringPalindrome()
{
    Console.Write("Enter a string to check if it's a palindrome: ");
    string input = Console.ReadLine();
    
    int left = 0;
    int right = input.Length - 1;
    bool isPalindrome = true;

    while (left < right)
    {
        if (char.ToLower(input[left]) != char.ToLower(input[right]))
        {
            isPalindrome = false;
            break;
        }
        left++;
        right--;
    }

    Console.WriteLine(isPalindrome ? $"{input} is a palindrome." : $"{input} is not a palindrome.\n\n");
}


    static void ReverseWordsInSentence()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        Array.Reverse(words);
        string reversedSentence = string.Join(" ", words);

        Console.WriteLine($"Reversed sentence: {reversedSentence}\n\n");
    }

    static void RemoveDuplicatesFromArray()
{
    Console.Write("Enter number of elements in array: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[n];

    
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Enter elements no {i+1}");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    HashSet<int> uniqueSet = new HashSet<int>();
    foreach (int num in arr)
    {
        uniqueSet.Add(num); 
    }

    Console.WriteLine("Array after removing duplicates: " + string.Join(", ", uniqueSet) + "\n\n");
}


    static void StudentMarksManager()
    {
        var students = new Dictionary<string, int>();

        while (true)
        {
            Console.Write("Enter student name (or 'exit' to finish): ");
            string name = Console.ReadLine();
            if (name.ToLower() == "exit") break;
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty. Please enter a valid name.\n");
                Console.Write("Enter student name (or 'exit' to finish): ");
                name = Console.ReadLine();
                if (name.ToLower() == "exit") break;
            }
            Console.Write("Enter marks for " + name + ": ");
            int marks = Convert.ToInt32(Console.ReadLine());
            students[name] = marks;
        }

        Console.WriteLine("Student marks:");
        foreach (var kvp in students)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
        Console.WriteLine("\n\n");
    }

    static void PatientVisitConsoleApp()
    {
        var patients = new List<string>();

        while (true)
        {
            Console.Write("Enter patient name (or 'exit' to finish): ");
            string name = Console.ReadLine();
            if (name.ToLower() == "exit") break;
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty . Please enter a valid name.\n");
                continue;
            }
            patients.Add(name);
        }

        Console.WriteLine("Patients visited:");
        foreach (var patient in patients)
        {
            Console.WriteLine(patient);
        }
        Console.WriteLine("\n\n");
    }
    
    static void WordFrequencyCounter()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();
        var words = input.Split(' ');
        var frequency = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (frequency.ContainsKey(word))
                frequency[word]++;
            else
                frequency[word] = 1;
        }

        Console.WriteLine("Word frequencies:");
        foreach (var kvp in frequency)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }   
    static void RandomPasswordGenerator()
    {
        Console.Write("Enter password length: ");
        int length = Convert.ToInt32(Console.ReadLine());
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random random = new Random();
        string password = "";

        for (int i = 0; i < length; i++)
        {
            int index = random.Next(chars.Length);
            password += chars[index];
        }

        Console.WriteLine($"Generated password: {password}\n\n");
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
            while (choice > 30 || choice < 0)
            {
                Console.Write("Enter choice between 0-30 : ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            if (choice == 0)
            {
                Console.WriteLine("\n\n......You have exited the program....");
                break;
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
                case 6:
                    Factorial();
                    break;
                case 7:
                    LeapYear();
                    break;
                case 8:
                    FibonacciSeries();
                    break;
                case 9:
                    PrimeNumberChecker();
                    break;
                case 10:
                    GCD();
                    break;
                case 11:
                    SimpleCalculator();
                    break;
                case 12:
                    DigitCounter();
                    break;
                case 13:
                    PalindromeNumber();
                    break;
                case 14:
                    SumOfDigits();
                    break;
                case 15:
                    CheckArmstrong();
                    break;
                case 16:
                    MaxMinInArray();
                    break;
                case 17:
                    LinearSearch();
                    break;
                case 18:
                    ArraySortAscending();
                    break;
                case 19:
                    EvenOddCounterInArray();
                    break;
                case 20:
                    SortListOfNames();
                    break;
                case 21:
                    FrequencyCounter();
                    break;
                case 22:
                    MatrixAddition();
                    break;
                case 23:
                    VowelCounterInString();
                    break;
                case 24:
                    StringPalindrome();
                    break;
                case 25:
                    ReverseWordsInSentence();
                    break;
                case 26:
                    RemoveDuplicatesFromArray();
                    break;
                case 27:
                    StudentMarksManager();
                    break;
                case 28:
                    PatientVisitConsoleApp();
                    break;
                case 29:
                    WordFrequencyCounter();
                    break;
                case 30:
                    RandomPasswordGenerator();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.\n\n");
                    break;                   
            }


        }


    }
}