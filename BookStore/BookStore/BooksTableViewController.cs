using Foundation;
using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using UIKit;

namespace BookStore
{
    public partial class BooksTableViewController : UITableViewController
    {
        List<Book> bookList;
        public BooksTableViewController (IntPtr handle) : base (handle)
        {
            bookList = new List<Book>;

            bookList.Add(new Book () {
                Author = "J.K Rowling",
                Name = "Harry Potter and the Sorcerer's Stone",
                Publisher = "Bloomsbury",
                Year = 1997
            });
			bookList.Add(new Book () {
				Author = "J.K Rowling",
				Name = "Harry Potter and the Chamber of Secrets",
				Publisher = "Bloomsbury",
				Year = 1998
			});
			bookList.Add(new Book () {
				Author = "J.K Rowling",
				Name = "Harry Potter and the Prisoner of Azkaban",
				Publisher = "Bloomsbury",
				Year = 1999
			});
        }
    }

    public class Book
    {
        public string Name;
        public string Author;
        public string Publisher;
        public string Year;
    }
}