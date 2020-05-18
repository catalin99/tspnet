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
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ASPNetCore.Pages.SpecialProperties
{
    public class AssignToMediaModel : PageModel
    {
        private readonly ASPNetCore.Data.ASPNetCoreContext _context;
        ProjectClient projectClient = new ProjectClient();

        public AssignToMediaModel(ASPNetCore.Data.ASPNetCoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PropertyDTO PropertyDTO { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await projectClient.CreatePropertyAsync(PropertyDTO.Description, PropertyDTO.MediaID, PropertyDTO.PropertyCodeID);

            return RedirectToPage("./SpecialProperties");
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propCodes = await projectClient.GetPropertyCodesAsync();
            var myPropCode = propCodes.FirstOrDefault(p => p.ID == (int)id);

            if (myPropCode == default(ModelDesignFirst_L1.PropertyCode))
            {
                return NotFound();
            }

            PropertyDTO = new PropertyDTO();
            PropertyDTO.Title = myPropCode.Code;
            PropertyDTO.PropertyCodeID = myPropCode.ID;

           
            var movies = await projectClient.GetAllMoviesAsync();
            var selectedMovies = movies.Select(m => new SelectListItem
            {
                Value = m.ID.ToString(),
                Text = m.MovieName
            }).ToList();
            var photos = await projectClient.GetAllPhotosAsync();
            var selectedPhotos = photos.Select(p => new SelectListItem
            {
                Value = p.ID.ToString(),
                Text = p.PhotoName
            }).ToList();
            PropertyDTO.Media=selectedPhotos;
            PropertyDTO.Media.AddRange(selectedMovies);

            return Page();
        }

    }
}
