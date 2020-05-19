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
            string[] article = Console.ReadLine().Split(",").ToArray();
            int commandCount = int.Parse(Console.ReadLine());
            Article article1 = new Article();
            for (int i = 0; i < commandCount; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                switch(command[0])
                {
                    case "Edit:":
                        article1.Edit(command[0], command[1]);
                        break;

                    case "ChangeAuthor:":
                        article1.ChangeAuthor(command[0], command[1]);
                        break;

                    case "Rename:":
                        article1.Rename(command[0], command[1]);
                        break;

                        
                }
                
            }
            string result = article1.Pesho(article1.Title, article1.Content, article1.Author);

            Console.WriteLine(result);

        }
        class Article
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public string Edit(string command, string value)
            {
                return Content = value;
            }
            public string ChangeAuthor(string command, string value)
            {
                return Author = value;
            }
            public string Rename(string command, string value)
            {
                return Title = value;
            }
            public  string Pesho(string Title, string Content, string Author)
            {
                return ($"{Title} title - {Content} content: {Author} author");
            }
        }
    }
}
