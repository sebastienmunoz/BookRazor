using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookRazor
{
    public class AppSettings
    {
        public string connectionStr { get; set; } = @"Data Source=.\SQLEXPRESS;Initial Catalog=BOOK;Integrated Security=SSPI";
    }
}
