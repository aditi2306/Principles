using System;
using System.Collections.Generic;
using System.Linq;

namespace PrinciplesExamples
{ 
    class KISSExample
    {
        //Keep It Simple, Stupid
        private List<Book> listBooks = new List<Book>();

        public KISSExample(List<Book> books)
        {
            this.listBooks = books;
        }

        public Book SelectedBookDetails(string selectedBookName)
        {
            //Exception handling for null checks
            if (string.IsNullOrEmpty(selectedBookName) || string.IsNullOrWhiteSpace(selectedBookName))
                throw new Exception("Select or choose a book name");

            //Linq can be used instead of for loop
            //provides maintainability and simplicity

            return listBooks.Where(x => x.Name.Equals(selectedBookName.Trim())).First();
        }
        
        public List<Book> AddAmountBasedOnType()
        {
            //Enum values and switch cases can be used instead of if statements
            //simplicity to gain more extendable code

            foreach (Book book in listBooks)
            {
                switch (book.Type)
                {
                    case BookType.Fiction:
                        book.Price += 10;
                        break;
                    case BookType.NonFiction:
                        book.Price += 5;
                        break;
                }
            }

            return listBooks.OrderBy(x=>x.Price).ToList();
        }

    }

    public enum BookType
    {
        Fiction,
        NonFiction
    }
    public class Book
    {
        public string Description { get; set; }
        public string  Name { get; set; }
        public Guid Id { get; set; }
        public BookType Type { get; set; }
        public int Price { get; set; }
    }
}
