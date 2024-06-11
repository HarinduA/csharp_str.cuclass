using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }

    public Book(string title, string author, int publicationYear)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
    }

    // Method to get a description of the book
    public string Description()
    {
        return $"'{Title}' by {Author}, published in {PublicationYear}.";
    }

    // Method to check if the book is a classic (published over 50 years ago)
    public bool IsClassic()
    {
        int currentYear = DateTime.Now.Year;
        return currentYear - PublicationYear > 50;
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of the Book class
        Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", 1960);

        // Using the methods from the Book class
        Console.WriteLine(book1.Description());
        Console.WriteLine($"Is '{book1.Title}' a classic? {(book1.IsClassic() ? "Yes" : "No")}");

        // String manipulation examples
        string text = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine($"Original text: {text}");

        // Splitting the string into words
        string[] words = text.Split(' ');
        Console.WriteLine("Words in the text:");
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }

        // Joining the words back into a sentence
        string joinedText = string.Join(" ", words);
        Console.WriteLine($"Joined text: {joinedText}");

        // Substring example
        string substring = text.Substring(10, 9);
        Console.WriteLine($"Substring (starting at index 10, length 9): {substring}");
    }
}
