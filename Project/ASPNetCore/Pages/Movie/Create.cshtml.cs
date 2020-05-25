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

namespace ASPNetCore.Pages.Movie
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
        public MovieDTO MovieDTO { get; set; }
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

            ////Configure Mapper
            var config = new MapperConfiguration(mc => mc.CreateMap<MovieDTO, ModelDesignFirst_L1.Movie>());
            //Map the objects
            var mapper = new Mapper(config);
            var movie = mapper.Map<MovieDTO, ModelDesignFirst_L1.Movie>(MovieDTO);
            movie.MovieName = Upload.FileName;
            string relativePath = @"~/Resources/Videos/" + Path.GetFileName(Upload.FileName);
            movie.FullPath = relativePath;

            await projectClient.CreateMovieAsync(movie.FullPath, movie.MovieName, movie.CreationDate, movie.Event, movie.TaggedPersons, movie.Location, movie.Duration);

            return RedirectToPage("./Index");
        }
    }
}
