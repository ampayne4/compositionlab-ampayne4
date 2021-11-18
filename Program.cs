using System;

namespace composition_lab_ampayne4
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("Alex Payne", 'm', "ampayne4@crimson.ua.edu");
            Console.WriteLine(myAuthor.ToString());
            Book myBook = new Book("12345", "Lonesome Dove", myAuthor);
            Console.WriteLine(myBook.ToString());
            Console.WriteLine(myBook.GetAuthor().ToString());
            Book yourBook = new Book("67890", "Harry Potter", new Author("J.K. Rowling", 'f', "jkrowling@gmail.com"));
            Console.WriteLine(yourBook.ToString());
            yourBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");
            Console.WriteLine(yourBook.ToString());
        }
    }
}
