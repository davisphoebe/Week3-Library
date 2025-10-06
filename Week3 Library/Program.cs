
using System;

class Book
{
    string Title;
    string Author;
    string ISBN;

    void DisplayInfo()
    {
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //new object book with values
        Book book = new Book();
        book.Title = "C# for Beginners";
        book.Author = "BillGates";
        book.ISBN = "12345678";


        //new object book1 with values
        Book book1 = new Book();
        book1.Title = "C# Methods and classes";
        book1.Author = "Microsoft";
        book1.ISBN = "55667778";

        //output to console
        book.DisplayInfo();
        book1.DisplayInfo();
    }
}
