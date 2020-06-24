using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Net.Mime;

namespace articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] article = Console.ReadLine().Split(", ").ToArray();
            int commandCount = int.Parse(Console.ReadLine());
            Article article1 = new Article();
            article1.Title = article[0];
            article1.Content = article[1];
            article1.Author = article[2];
            for (int i = 0; i < commandCount; i++)
            {
                string[] command = Console.ReadLine().Split(": ").ToArray();

                switch(command[0])
                {
                    case "Edit":
                        article1.Edit(command[1]);
                        break;

                    case "ChangeAuthor":
                        article1.ChangeAuthor(command[1]);
                        break;

                    case "Rename":
                        article1.Rename(command[1]);
                        break;

                        
                }
                
            }
            string result = article1.ToString();

            Console.WriteLine(result);

        }
        class Article
        {
            public Article()
            { 
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public string Edit(string value)
            {
                return Content = value;
            }
            public string ChangeAuthor(string value)
            {
                return Author = value;
            }
            public string Rename(string value)
            {
                return Title = value;
            }
            public override string ToString()
            {
                return ($"{Title} - {Content}: {Author}");
            }
        }
    }
}
