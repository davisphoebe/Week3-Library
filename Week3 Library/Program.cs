
using System;

class Book
{
    string Title;
    string Author;
    string ISBN;


    //constructor
    public Book(string bookTitle, string bookAuthor, string bookISBN)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
    }

    void DisplayInfo()
    {
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //new objects with values
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");
        Book book1 = new Book("C# Methods and classes", "Microsoft", "55667778");


        //output to console
        book.DisplayInfo();
        book1.DisplayInfo();
    }
}
