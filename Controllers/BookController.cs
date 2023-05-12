using BookStore.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Controllers
{
    [Route("app/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static List<Book> BookList = new List<Book>()
        {
            new Book
            {
                Id = 1,
                Title = "Web API",
                GenreId = 1,
                PageCount = 275,
                PublishDate = new System.DateTime(2023,05,10)
            },
            new Book
            {
                Id = 2,
                Title = "NodeJS Geleceği Ele Geçirecek!!!",
                GenreId = 2,
                PageCount = 183,
                PublishDate = new System.DateTime(2021,08,24)
            },
            new Book
            {
                Id = 3,
                Title = "Python",
                GenreId = 2,
                PageCount = 183,
                PublishDate = new System.DateTime(2021,08,24)
            },
            new Book
            {
                Id = 4,
                Title = "C#",
                GenreId = 2,
                PageCount = 183,
                PublishDate = new System.DateTime(2021,08,24)
            }
        };

        [HttpGet("get-book-list")]
        public List<Book> GetBooks()
        {
            var bookList = BookList.OrderBy(x => x.Id).ToList();
            return bookList;
        }

        [HttpGet("get-by-id/{id}")]
        public Book GetBook(int id)
        {
            var book = BookList.Where(b => b.Id == id).SingleOrDefault();
            return book;

        }
    }
}
