using System;
using System.Collections.Generic;

namespace PrinciplesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //KISS Principle
            List<Book> books = new List<Book>();
            books.Add(ReturnBookFunc("Agile Principles, and Solid Principles", "Agile Principles, Patterns, and Practices in C#",400,BookType.NonFiction,Guid.NewGuid()));
            books.Add(ReturnBookFunc("Brazilian author Paulo Coelho", "The Alchemist", 500, BookType.Fiction, Guid.NewGuid()));
            books.Add(ReturnBookFunc("an Indian boy from Pondicherry, India who explores issues of spirituality and metaphysics", "Life of Pi", 600, BookType.Fiction, Guid.NewGuid()));

            //KISS Example
            KISSExample principleKissExample = new KISSExample(books);

            principleKissExample.AddAmountBasedOnType();

            foreach (Book book in books)
            {
                Console.WriteLine(book.Name+" "+book.Description+" "+book.Price+" "+book.Type);
            }

            var res= principleKissExample.SelectedBookDetails("The Alchemist");
            if (res == null)
            {
                Console.WriteLine("Book not found");
            }
            else
            {
                Console.WriteLine("Selected book " + res.Name + " " + res.Description + " " + res.Price + " " + res.Type);
            }


            //KISS Problem
            KISSProblem principleKissProblem = new KISSProblem(books);

            principleKissProblem.AddAmountBasedOnType();

            foreach (Book book in books)
            {
                Console.WriteLine(book.Name + " " + book.Description + " " + book.Price + " " + book.Type);
            }

            var result = principleKissProblem.SelectedBookDetails("The Alchemist");
            if (result==null)
            {
                Console.WriteLine("Book not found");
            }
            else
            {
                Console.WriteLine("Selected book " + result.Name + " " + result.Description + " " + result.Price + " " + result.Type);
            }


            //DependencyInversionViolation
            Loggers logger = new Loggers();
            Customer customer = new Customer(logger);
            customer.Delivered();

            //DependencyInversionExample
            ILogger log = new Logger();
            BestCustomer bestCustomer = new BestCustomer(log);
            bestCustomer.Delivered();

        }
        static Book ReturnBookFunc(string description, string name, int price, BookType type, Guid Id)
        {
            Book book = new Book();
            book.Description = description;
            book.Id = Id;
            book.Name = name;
            book.Price = price;
            book.Type = type;
            return book;
        }
    }
}
