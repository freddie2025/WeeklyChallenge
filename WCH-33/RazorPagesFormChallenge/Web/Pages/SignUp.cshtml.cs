using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Web.Models;

namespace Web.Pages
{
    public class SignUpModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Mode { get; set; } = "Light";

        [BindProperty]
        public SignUpDataModel SignUpData { get; set; } = new SignUpDataModel();

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }

            return RedirectToPage("./ThankYou", new { id = 15 });
        }
    }
}