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
    public class IndexModel : PageModel
    {
        ProjectClient projectClient = new ProjectClient();
        private readonly ASPNetCore.Data.ASPNetCoreContext _context;
        public IList<PhotoDTO> Photos { get; set; }

        public IndexModel(ASPNetCore.Data.ASPNetCoreContext context)
        {
            _context = context;
            Photos = new List<PhotoDTO>();
        }

        public async Task OnGetAsync()
        {
            var photos = await projectClient.GetAllPhotosAsync();
            //Configure Mapper
            var config = new MapperConfiguration(mc => mc.CreateMap<ModelDesignFirst_L1.Photo, PhotoDTO>());
            //Map the objects
            var mapper = new Mapper(config);
            Photos = mapper.Map<List<ModelDesignFirst_L1.Photo>, List<PhotoDTO>>(photos);
        }
    }
}
