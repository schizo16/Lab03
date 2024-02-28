using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string ImageUrl { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Summary { get; set; }

        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book() { Id = 1, Title = "Chí Phèo", AuthorId=1,
                GenreId=2,ImageUrl="/images/books/b1.jpg",Price=500000,
                Summary="",TotalPage=250},
                new Book() { Id = 2, Title = "Lão Hạc", AuthorId=1,
                GenreId=2,ImageUrl="/images/books/b2.jpg",Price=700000,
                Summary="",TotalPage=200},
                new Book() { Id = 3, Title = "Conan", AuthorId=2,
                GenreId=1,ImageUrl="/images/books/b3.jpg",Price=800000,
                Summary="",TotalPage=200},
                new Book() { Id = 4, Title = "Bố già", AuthorId=3,
                GenreId=2,ImageUrl="/images/books/b4.jpg",Price=200000,
                Summary="",TotalPage=300},
                new Book() { Id = 5, Title = "Đô-rê-mon", AuthorId=1,
                GenreId=1,ImageUrl="/images/books/b5.jpg",Price=300000,
                Summary="",TotalPage=50},
            };
            return books;
        }

        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b=>b.Id == id);
            return book;
        }
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value="1", Text="Nam Cao"},
            new SelectListItem {Value="2", Text="Mario Puzo"},
            new SelectListItem {Value="3", Text="Kim Đồng"},
            

        };
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1",Text="Truyện tranh"},
            new SelectListItem{Value="2",Text="Văn học đương đại"},
            new SelectListItem{Value="3",Text="Truyện cười"},
            new SelectListItem{Value="4",Text="Truyện ma"},
        };
    }
}
