using System;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public Person(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    // Method to get the full name
    public string FullName()
    {
        return $"{FirstName} {LastName}";
    }

    // Method to introduce the person
    public string IntroduceYourself()
    {
        return $"Hello, my name is {FullName()} and I am {Age} years old.";
    }

    // Method to check if the person is an adult
    public bool IsAdult()
    {
        return Age >= 18;
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the Person class
        Person person1 = new Person("John", "Doe", 25);

        // Using the methods from the Person class
        Console.WriteLine(person1.IntroduceYourself());
        Console.WriteLine($"Is {person1.FullName()} an adult? {(person1.IsAdult() ? "Yes" : "No")}");

        // String manipulation examples
        string favoriteQuote = "To be or not to be, that is the question.";
        Console.WriteLine($"Original quote: {favoriteQuote}");

        // Converting to uppercase
        string uppercaseQuote = favoriteQuote.ToUpper();
        Console.WriteLine($"Uppercase quote: {uppercaseQuote}");

        // Finding the position of a substring
        int position = favoriteQuote.IndexOf("question");
        Console.WriteLine($"Position of 'question': {position}");

        // Replacing a word in the quote
        string replacedQuote = favoriteQuote.Replace("be", "code");
        Console.WriteLine($"Replaced quote: {replacedQuote}");
    }
}
