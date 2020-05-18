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
    public class IndexModel : PageModel
    {
        private readonly ASPNetCore.Data.ASPNetCoreContext _context;
        ProjectClient projectClient = new ProjectClient();
        public IList<MovieDTO> Movies { get; set; }

        public IndexModel(ASPNetCore.Data.ASPNetCoreContext context)
        {
            _context = context;
            Movies = new List<MovieDTO>();
        }

        public async Task OnGetAsync()
        {
            var movies = await projectClient.GetAllMoviesAsync();
            //Configure Mapper
            var config = new MapperConfiguration(mc => mc.CreateMap<ModelDesignFirst_L1.Movie, MovieDTO>());
            //Map the objects
            var mapper = new Mapper(config);
            Movies = mapper.Map<List<ModelDesignFirst_L1.Movie>, List<MovieDTO>>(movies);
        }
    }
}
