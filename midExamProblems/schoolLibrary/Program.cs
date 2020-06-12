using System;
using System.Collections.Generic;
using System.Linq;

namespace schoolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = Console.ReadLine().Split("&",StringSplitOptions.RemoveEmptyEntries).ToList();

            var input = Console.ReadLine();

            while (input != "Done")
            {
                var command = input.Split(" | ",StringSplitOptions.RemoveEmptyEntries).ToArray();
                var action = command[0];
                switch (action)
                {
                    case "Add Book":
                        var bookName = command[1];
                        AddBook(books,bookName);
                        break;
                    case "Take Book":
                        bookName = command[1];
                        TakeBook(books, bookName);
                        break;
                    case "Swap Books":
                        var book1 = command[1];
                        var book2 = command[2];
                        SwapBooks(books, book1, book2);
                        break;
                    case "Insert Book":
                        bookName = command[1];
                        InsertBook(books, bookName);
                        break;
                    case "Check Book":
                        int index = int.Parse(command[1]);
                        if (index >=0 && index <= books.Count - 1)
                        {
                        Console.WriteLine(books[index]);
                            
                        }
                        
                      
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",books));
        }
        static List<string> AddBook(List<string>books, string bookName)
        {
            if (!books.Contains(bookName))
            {
                 books.Insert(0,bookName);
                return books;
            }
            return books;
        }
        static List<string> TakeBook(List<string> books, string bookName)
        {
            if (books.Contains(bookName))
            {
                books.Remove(bookName);
                return books;
            }
            return books;
        }
        static List<string> InsertBook(List<string> books, string bookName)
        {
            books.Add(bookName);
            return books;
        }
       
        static List<string> SwapBooks(List<string> books, string book1, string book2)
        {
            if (books.Contains(book1) && books.Contains(book2))
            {
                var index1 = books.IndexOf(book1);
                var index2 = books.IndexOf(book2);
                if (index1 > index2)
                {
                    books.RemoveAt(index1);
                    books.RemoveAt(index2);
                }
                else if (index1 == index2)
                { 
                        return books;
                }
                else
                {
                    books.RemoveAt(index1);
                    books.RemoveAt(index2 - 1);
                }
                books.Insert(index1, book2);
                books.Insert(index2, book1);
                return books;
            }
            return books;
            
        }
    }
}
