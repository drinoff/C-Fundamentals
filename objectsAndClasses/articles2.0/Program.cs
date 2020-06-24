using System;
using System.Collections.Generic;
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
            int commandCount = int.Parse(Console.ReadLine());
            var list = new List<Article>();

            for (int i = 0; i < commandCount; i++)
            {
                Article article = new Article();
                string[] input = Console.ReadLine().Split(", ").ToArray();
                article.Title = input[0];
                article.Content = input[1];
                article.Author = input[2];

                list.Add(article);

            }
            var order = Console.ReadLine();
            
            switch (order)
            {
                case "title":
                   var result = list.OrderBy(x => x.Title);
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
                    break;
                case "author":
                    result = list.OrderBy(x => x.Author);
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    break;
                case "content":
                    result = list.OrderBy(x => x.Content);
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.ToString());
                    }
                    break;
            }



        }
        class Article
        {
            public Article()
            {
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }


            public override string ToString()
            {
                return ($"{Title} - {Content}: {Author}");
            }
        }
    }
}

