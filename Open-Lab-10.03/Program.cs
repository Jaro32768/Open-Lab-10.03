using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.SetTitle("Creative name of book");
            LOTR.SetPages(100);
            LOTR.SetCategory("encyclopedia");
            LOTR.SetAuthor("Jaro");
            LOTR.SetReleaseDate("7.11.2020");
            LOTR.GetBook();
            Console.ReadKey();
        }
    }
    class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private string releaseDate;
        public void SetTitle(string str)
        {
            this.title = str;
        }
        public void SetPages(int i)
        {
            this.pages = i;
        }
        public void SetCategory(string str)
        {
            this.category = str;
        }
        public void SetAuthor(string str)
        {
            this.author = str;
        }
        public void SetReleaseDate(string str)
        {
            this.releaseDate = str;
        }
        public void GetBook()
        {
            Console.WriteLine(String.Format($"Book \"{ title}\" has {pages} pages, it is {category} by {author} and it was released {releaseDate}."));
        }
    }
}