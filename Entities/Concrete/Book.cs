using BookStore.Entities.Abstract;
using System;

namespace BookStore.Entities.Concrete
{
    public class Book: IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
