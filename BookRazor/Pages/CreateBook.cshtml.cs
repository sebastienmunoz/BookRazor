using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookRazor.Models;

namespace BookRazor.Pages
{
    public class CreateBookModel : PageModel
    {
        public string connectionStr = new AppSettings().connectionStr;

        [BindProperty]
        public Book book { get; set; }

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            book.CreateBook(connectionStr, book);

            return RedirectToPage("./Books");
        }
    }
}