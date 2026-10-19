using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace NetCoreMVCLab4.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }

        // danh sách các cuốn sách (nhớ using System.Collections.Generic)
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book(){
                    Id =1,
                    Title = "Chí Phèo",
                    AuthorId =1,
                    GenreId = 1,
                    Image ="/images/products/b1.jpg",
                    Price =500000,
                    Sumary ="",
                    TotalPage = 250
                },
                new Book() {
                    Id = 2,
                    Title = "Tắt Đèn",
                    AuthorId = 2,
                    GenreId = 1,
                    Image = "/images/products/b2.jpg",
                    Price = 400000,
                    Sumary = "",
                    TotalPage = 180
                },
                new Book() {
                    Id = 3,
                    Title = "Lão Hạc",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/products/b3.jpg",
                    Price = 350000,
                    Sumary = "",
                    TotalPage = 150
                },
                new Book() {
                    Id = 3,
                    Title = "Làm Đĩ",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/products/b3.jpg",
                    Price = 350000,
                    Sumary = "",
                    TotalPage = 200
                }


            };

            return books;
        }
        public Book GetBookById(int id)
        {
            Book book=this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;

        }
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
{
    new SelectListItem {Value="1", Text="Nam cao"},
    new SelectListItem {Value="2", Text="Ngô Tất Tố"},
    new SelectListItem {Value="3", Text="Nam Cao"},
    new SelectListItem {Value="4", Text="Vũ Trọng Phụng"}
};

        // SelectListItem Genres
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
{
    new SelectListItem{Value="1", Text="Truyện tranh"},
    new SelectListItem{Value="2", Text="Văn học đương đại"},
    new SelectListItem{Value="3", Text="Phật học phổ thông"},
    new SelectListItem{Value="4", Text="Truyền cười"}
};

    }
}