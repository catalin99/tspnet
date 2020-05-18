using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPNetCore.Data;
using ASPNetCore.Models;
using ServiceReferenceMyPhotos;
using AutoMapper;

namespace ASPNetCore.Pages.Photo
{
    public class EditModel : PageModel
    {
        private readonly ASPNetCore.Data.ASPNetCoreContext _context;
        ProjectClient projectClient = new ProjectClient();

        public EditModel(ASPNetCore.Data.ASPNetCoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PhotoDTO PhotoDTO { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var photo = await projectClient.GetPhotoByIdAsync((int)id);

            ////Configure Mapper
            var config = new MapperConfiguration(mc => mc.CreateMap<ModelDesignFirst_L1.Photo, PhotoDTO>());
            //Map the objects
            var mapper = new Mapper(config);


            PhotoDTO = mapper.Map<ModelDesignFirst_L1.Photo, PhotoDTO>(photo);

            if (PhotoDTO == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }           

            try
            {
                await projectClient.UpdatePhotoAsync(PhotoDTO.ID, PhotoDTO.FullPath, PhotoDTO.PhotoName, PhotoDTO.CreationDate, PhotoDTO.Event,
                    PhotoDTO.TaggedPersons, PhotoDTO.Location, PhotoDTO.Height, PhotoDTO.Weight);
            }
            catch (DbUpdateConcurrencyException)
            {
                var photo = projectClient.GetPhotoByIdAsync(PhotoDTO.ID);
                if (photo == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }
    }
}
