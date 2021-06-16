using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLib
{
    public class Book
    {
        static int index = 0;
        int BookID;
        public void setID(int ID)
        {
            this.BookID = ID;
        }
        public int getID()
        {
            return this.BookID;
        }
        //-----------------------------------------------
        string Title;
        public void setTitle(string title)
        {
            this.Title = title;
        }
        public string getTitle()
        {
            return this.Title;
        }
        //-----------------------------------------------
        string Author;
        public void setAuthor(string author)
        {
            this.Author = author;
        }
        public string getAuthor()
        {
            return this.Author;
        }
        //-----------------------------------------------
        string Publisher;
        public void setPublisher(string publisher)
        {
            this.Publisher = publisher;
        }
        public string getPulisher()
        {
            return this.Publisher;
        }
        //-----------------------------------------------
        public Book()
        {

        }

        public Book(int ID, string titile, string author, string publisher)
        {
            BookID = ID;
            Title = titile;
            Author = author;
            Publisher = publisher;
        }

        public void Print()
        {
            Console.WriteLine("ID: {0}", BookID);
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Author: {0}", Author);
            Console.WriteLine("Pulisher: {0}", Publisher);
            Console.WriteLine("---------------------------\n");
        }

        public void input()
        {
            Console.WriteLine("Enter Book's information");
            Console.WriteLine("Book's ID: {0}", index + 1);
            setID(index + 1);
            Console.Write("Book's name: ");
            string Title = Console.ReadLine();
            setTitle(Title);
            Console.Write("Book's Author: ");
            string Author = Console.ReadLine();
            setAuthor(Author);
            Console.Write("Book's Publisher: ");
            string Publisher = Console.ReadLine();
            setPublisher(Publisher);
            index++;
        }

    }
}
