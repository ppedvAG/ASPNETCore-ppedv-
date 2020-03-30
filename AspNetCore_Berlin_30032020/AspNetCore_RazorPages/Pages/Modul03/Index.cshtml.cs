using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCore_RazorPages.Pages.Modul03
{
    public class IndexModel : PageModel
    {
        public int MyProperty { get; set; }

        public void OnGet()
        {
            MyProperty = 7;
        }
    }
}
