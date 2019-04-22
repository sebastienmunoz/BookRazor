using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookRazor.Models;
using BookRazor;

namespace BookRazor.Pages
{
    public class BooksModel : PageModel
    {
        public string connectionStr = new AppSettings().connectionStr;

        public Book book = new Book();
        public List<Book> books { get; set; }

        public void OnGet()
        {
            books = book.GetBooks(connectionStr).ToList();
        }
    }
}
