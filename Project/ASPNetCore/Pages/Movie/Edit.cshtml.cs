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

namespace ASPNetCore.Pages.Movie
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
        public MovieDTO MovieDTO { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await projectClient.GetMovieByIdAsync((int)id);
            ////Configure Mapper
            var config = new MapperConfiguration(mc => mc.CreateMap<ModelDesignFirst_L1.Movie, MovieDTO>());
            //Map the objects
            var mapper = new Mapper(config);

            MovieDTO = mapper.Map<ModelDesignFirst_L1.Movie, MovieDTO>(movie);

            if (MovieDTO == null)
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

            _context.Attach(MovieDTO).State = EntityState.Modified;

            try
            {
                await projectClient.UpdateMovieAsync(MovieDTO.ID, MovieDTO.FullPath, MovieDTO.MovieName, MovieDTO.CreationDate, MovieDTO.Event,
                   MovieDTO.TaggedPersons, MovieDTO.Location, MovieDTO.Duration);
            }
            catch (DbUpdateConcurrencyException)
            {
                var movie = projectClient.GetMovieByIdAsync(MovieDTO.ID);
                if (movie == null)
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
