using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinciplesExamples
{
    public class KISSProblem
    {
        //Keep It Simple, Stupid
        public List<Book> listBooks = new List<Book>();

        public KISSProblem(List<Book> books)
        {
            this.listBooks = books;
        }

        public Book SelectedBookDetails(string selectedBookName)
        {
            //Exception handling for null checks
            if (string.IsNullOrEmpty(selectedBookName) || string.IsNullOrWhiteSpace(selectedBookName))
                throw new Exception("Select or choose a book name");

            foreach (Book book in listBooks)
            {
                if (book.Name.Equals(selectedBookName.Trim()))
                {
                    return book;
                }
            }
            return null;
        }

        public List<Book> AddAmountBasedOnType()
        {
            foreach (Book book in listBooks)
             {
                 if (book.Type.Equals("Fiction"))
                 {
                     book.Price += 10;
                 }
                 else if(book.Type.Equals("NonFiction"))
                 {
                     book.Price += 5;
                 }
             }
            return listBooks;
        }

    }

}

