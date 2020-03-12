using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebUI.Models;

namespace WebUI.Pages
{
    public class SayHiModel : PageModel
    {
        [BindProperty]
        public PersonModel Person { get; set; } = new PersonModel();

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}