using EFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCodeFirst.Data
{
    public class DBInitialize
    {
        public static void Initialize(LibraryContext context)
        {
            if (!context.Author.Any())
            {
                var authors = new List<Author>
                {
                    new Author{ Name = "Paulo Coelho", MailId = "paulo.coelho@motivation.com" },
                    new Author{ Name = "Mitch Albom", MailId = "mitch.albom@motivation.com" },
                    new Author{ Name = "Jon Krakauer", MailId = "jon.krakauer@motivation.com" },
                    new Author{ Name = "Chetan Bhagat", MailId = "chetan.bhagat@motivation.com" }
                };
                context.Author.AddRange(authors);
                context.SaveChanges();
            }

            if (!context.Book.Any())
            {
                var books = new List<Book>
                {
                    new Book{ AuthorId=1, Title="Alchemist", Description="A touching story of a boy who chases after his dreams despite so many challengess", Price = 300},
                    new Book{ AuthorId=2, Title="Tuesdays with Morrie", Description="An Old man, a young man and life's greatest lesson", Price = 400},
                    new Book{ AuthorId=3, Title="Into the wild", Description="An adventure story of inspiring Christopher McCandless", Price = 500},
                    new Book{ AuthorId=4, Title="Five point someone", Description="A story of three friends and life lessons involing our current education system", Price = 600},
                };
                context.Book.AddRange(books);
                context.SaveChanges();
            }
        }
    }
}
