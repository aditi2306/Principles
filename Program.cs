﻿using System;
using System.Collections.Generic;

namespace PrinciplesExamples
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Book> books = new List<Book>();
            books.Add(ReturnBookFunc("Agile Principles, and Solid Principles", "Agile Principles, Patterns, and Practices in C#",400,BookType.NonFiction,Guid.NewGuid()));
            books.Add(ReturnBookFunc("Brazilian author Paulo Coelho", "The Alchemist", 500, BookType.Fiction, Guid.NewGuid()));
            books.Add(ReturnBookFunc("an Indian boy from Pondicherry, India who explores issues of spirituality and metaphysics", "Life of Pi", 600, BookType.Fiction, Guid.NewGuid()));


            KISS principleKiss = new KISS(books);
           
            principleKiss.AddAmountBasedOnType();

            foreach (Book book in books)
            {
                Console.WriteLine(book.Name+" "+book.Description+" "+book.Price+" "+book.Type);
            }

            principleKiss.SelectedBookDetails("The Alchemist");

            Book ReturnBookFunc(string description, string name, int price, BookType type, Guid Id)
            {
                Book book = new Book();
                book.Description =description;
                book.Id = Id;
                book.Name = name;
                book.Price =price;
                book.Type = type;
                return book;
            }
        }
    }
}
