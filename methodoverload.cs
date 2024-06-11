using System;

public class Calculator
{
    // Method to add two integers
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Overloaded method to add three integers
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Overloaded method to add two doubles
    public double Add(double a, double b)
    {
        return a + b;
    }

    // Overloaded method to add three doubles
    public double Add(double a, double b, double c)
    {
        return a + b + c;
    }

    // Overloaded method to add two strings
    public string Add(string a, string b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        // Using the Add method with two integers
        int sum1 = calculator.Add(2, 3);
        Console.WriteLine("Sum of 2 and 3: " + sum1);

        // Using the Add method with three integers
        int sum2 = calculator.Add(1, 2, 3);
        Console.WriteLine("Sum of 1, 2, and 3: " + sum2);

        // Using the Add method with two doubles
        double sum3 = calculator.Add(2.5, 3.5);
        Console.WriteLine("Sum of 2.5 and 3.5: " + sum3);

        // Using the Add method with three doubles
        double sum4 = calculator.Add(1.1, 2.2, 3.3);
        Console.WriteLine("Sum of 1.1, 2.2, and 3.3: " + sum4);

        // Using the Add method with two strings
        string sum5 = calculator.Add("Hello, ", "World!");
        Console.WriteLine("Concatenation of 'Hello, ' and 'World!': " + sum5);
    }
}
