using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebFileUploadSite.Models;

namespace WebFileUploadSite.Pages
{
    public class UploadAndParseModel : PageModel
    {
        [BindProperty]
        public IFormFile UploadedFile { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (UploadedFile?.Length > 0)
            {
                using var stream = UploadedFile.OpenReadStream();
                using var reader = new StreamReader(stream);
                List<PersonModel> people = new List<PersonModel>();
                string data;

                while ((data = reader.ReadLine()) != null)
                {
                    string[] entries = data.Split(',');

                    people.Add(new PersonModel
                    {
                        FirstName = entries[0],
                        LastName = entries[1],
                        EmailAddress = entries[2]
                    });
                }

                return RedirectToPage("./Index");
            }
            else
            {
                return Page();
            }
        }
    }
}