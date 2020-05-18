using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPNetCore.Data;
using ASPNetCore.Models;
using ServiceReferenceMyPhotos;
using AutoMapper;

namespace ASPNetCore.Pages.Photo
{
    public class DeleteModel : PageModel
    {
        private readonly ASPNetCore.Data.ASPNetCoreContext _context;
        ProjectClient projectClient = new ProjectClient();

        public DeleteModel(ASPNetCore.Data.ASPNetCoreContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
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

            if (PhotoDTO != null)
            {
                await projectClient.DeletePhotoAsync((int)id);
            }

            return RedirectToPage("./Index");
        }
    }
}
