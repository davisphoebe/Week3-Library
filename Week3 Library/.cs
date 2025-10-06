
using System;
using Week3_Library;

    static void Main(string[] args)
    {
        //new objects with values
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");
        Book book1 = new Book("C# Methods and classes", "Microsoft", "55667778");


        //output to console
        book.DisplayInfo();
        book1.DisplayInfo();
    }
