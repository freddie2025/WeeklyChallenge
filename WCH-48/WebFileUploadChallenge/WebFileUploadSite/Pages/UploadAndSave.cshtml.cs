using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebFileUploadSite.Pages
{
    public class UploadAndSaveModel : PageModel
    {
        private readonly IWebHostEnvironment hostEnvironment;

        public UploadAndSaveModel(IWebHostEnvironment hostEnvironment)
        {
            this.hostEnvironment = hostEnvironment;
        }

        [BindProperty]
        public IFormFile UploadedFile { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (UploadedFile?.Length > 0)
            {
                var uploadsFolder = Path.Combine(this.hostEnvironment.WebRootPath, "uploads");
                
                Directory.CreateDirectory(uploadsFolder);
                
                string fileNameExtension = UploadedFile.FileName.Substring(UploadedFile.FileName.IndexOf('.') + 1);
                string newFileName = $"{ Guid.NewGuid() }.{ fileNameExtension }";
                string filePath = Path.Combine(uploadsFolder, newFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await UploadedFile.CopyToAsync(fileStream);

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