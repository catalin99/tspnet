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

namespace ASPNetCore.Pages.Movie
{
    public class DetailsModel : PageModel
    {
        private readonly ASPNetCore.Data.ASPNetCoreContext _context;
        ProjectClient projectClient = new ProjectClient();

        public DetailsModel(ASPNetCore.Data.ASPNetCoreContext context)
        {
            _context = context;
        }

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
    }
}
