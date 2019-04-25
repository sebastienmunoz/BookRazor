using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookRazor.Pages
{
    public class EditBookModel : PageModel
    {

        public string connectionStr = new AppSettings().connectionStr;

        [BindProperty]
        public Book book { get; set; }

        //public ActionResult OnGet(int? bookId)
        //{
        //    if (bookId == null)
        //    {
        //        return NotFound();
        //    }
        //    book = book.getBookData(connectionStr, bookId);

        //    if (book == null)
        //    {
        //        return NotFound();
        //    }
        //    return Page();
        //}

        public ActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            book.EditBook(connectionStr);

            return RedirectToPage("./Books");
        }
    }
}