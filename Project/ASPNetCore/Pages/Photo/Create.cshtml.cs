using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASPNetCore.Data;
using ASPNetCore.Models;
using ServiceReferenceMyPhotos;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Web;

namespace ASPNetCore.Pages.Photo
{
    public class CreateModel : PageModel
    {
        private readonly ASPNetCore.Data.ASPNetCoreContext _context;
        ProjectClient projectClient = new ProjectClient();

        public CreateModel(ASPNetCore.Data.ASPNetCoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public PhotoDTO PhotoDTO { get; set; }
        [BindProperty]
        public IFormFile Upload { get; set; }


        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            PhotoDTO.PhotoName = Upload.FileName;
            string relativePath = @"~/Resources/Images/" + Path.GetFileName(Upload.FileName);
            PhotoDTO.FullPath = relativePath;
            await projectClient.CreatePhotoAsync(PhotoDTO.FullPath, PhotoDTO.PhotoName, PhotoDTO.CreationDate, PhotoDTO.Event, PhotoDTO.TaggedPersons, PhotoDTO.Location, PhotoDTO.Height, PhotoDTO.Weight);
            return RedirectToPage("./Index");
        }
    }
}
