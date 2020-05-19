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
        public string SearchName { get; set; }
        public string SearchEvent { get; set; }
        public string SearchPersons { get; set; }
        public string SearchLocation { get; set; }
        public bool DeleteFilter { get; set; }
        public int Count { get; set; }
        public string Filter { get; set; }
        public string SpecialProp { get; set; }

        public IndexModel(ASPNetCore.Data.ASPNetCoreContext context)
        {
            _context = context;
            Movies = new List<MovieDTO>();
        }


        public async Task OnPostAsync()
        {
            SearchName = Request.Form["SearchName"];
            SearchEvent = Request.Form["SearchEvent"];
            SearchPersons = Request.Form["SearchPersons"];
            SearchLocation = Request.Form["SearchLocation"];
            SpecialProp = Request.Form["SpecialProp"];
            DeleteFilter = Request.Form["DeleteFilter"] == "on" ? true : false;
            if (DeleteFilter == true)
            {
                SearchName = null;
                SearchEvent = null;
                SearchPersons = null;
                SearchLocation = null;
            }
            var movies = await projectClient.GetAllMoviesAsync();
            //Configure Mapper
            var config = new MapperConfiguration(mc => mc.CreateMap<ModelDesignFirst_L1.Movie, MovieDTO>());
            //Map the objects
            var mapper = new Mapper(config);
            Movies = mapper.Map<List<ModelDesignFirst_L1.Movie>, List<MovieDTO>>(movies);
            if (SearchName != string.Empty && SearchName != null)
            {
                Movies = Movies.Where(p => p.MovieName.ToUpper().Contains(SearchName.ToUpper()) || SearchName.ToUpper().Contains(p.MovieName.ToUpper())).ToList();
                Filter += "MovieName=" + SearchName + "; ";
            }
            if (SearchEvent != string.Empty && SearchEvent != null)
            {
                Movies = Movies.Where(p => p.Event.ToUpper().Contains(SearchEvent.ToUpper()) || SearchEvent.ToUpper().Contains(p.Event.ToUpper())).ToList();
                Filter += "Event=" + SearchEvent + "; ";
            }
            if (SearchLocation != string.Empty && SearchLocation != null)
            {
                Movies = Movies.Where(p => p.Location.ToUpper().Contains(SearchLocation.ToUpper()) || SearchLocation.ToUpper().Contains(p.Location.ToUpper())).ToList();
                Filter += "Location=" + SearchLocation + "; ";
            }
            if (SearchPersons != string.Empty && SearchLocation != null)
            {
                Movies = Movies.Where(p => p.TaggedPersons.ToUpper().Contains(SearchPersons.ToUpper()) || SearchPersons.ToUpper().Contains(p.TaggedPersons.ToUpper())).ToList();
                Filter += "Persons=" + SearchPersons + "; ";
            }
            if (SpecialProp != string.Empty && SpecialProp != null)
            {
                var propCodes = await projectClient.GetPropertyCodesAsync();
                var myPropCode = propCodes.FirstOrDefault(a => a.Code.ToUpper() == SpecialProp.ToUpper());
                if (myPropCode != default(ModelDesignFirst_L1.PropertyCode))
                {
                    var props = await projectClient.GetPropertiesByCodeIDAsync(myPropCode.ID);
                    var moviesIDs = props.Select(prop => prop.MediaID).ToList();
                    Movies = Movies.Where(p => moviesIDs.Contains(p.ID)).ToList();
                    Filter += "SpecialPropAssigned=" + SpecialProp;
                }
            }
            Count = Movies.Count();
        }

        public async Task OnGetAsync()
        {
            var movies = await projectClient.GetAllMoviesAsync();
            //Configure Mapper
            var config = new MapperConfiguration(mc => mc.CreateMap<ModelDesignFirst_L1.Movie, MovieDTO>());
            //Map the objects
            var mapper = new Mapper(config);
            Movies = mapper.Map<List<ModelDesignFirst_L1.Movie>, List<MovieDTO>>(movies);
            Count = Movies.Count();
            Filter = "";
        }
    }
}
