using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hackerRank
{
    class Solution
    {
        static void Main(String[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }

        abstract class Book
        {

            protected String title;
            protected String author;

            public Book(String t, String a)
            {
                title = t;
                author = a;
            }
            public abstract void display();
        }

        class MyBook : Book
        {
            protected int cost;

            public MyBook (string title, string author, int price) : base(title, author)
            {
               cost = price;  
            }

            public override void display()
            {
                Console.WriteLine("Title: " + title);
                Console.WriteLine("Author: " + author);
                Console.WriteLine("Price: " + cost);
            }
        }
    }
}
