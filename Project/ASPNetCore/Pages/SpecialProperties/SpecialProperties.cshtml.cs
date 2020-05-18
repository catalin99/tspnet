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

namespace ASPNetCore.Pages.SpecialProperties
{
    public class SpecialPropertiesModel : PageModel
    {
        private readonly ASPNetCore.Data.ASPNetCoreContext _context;
        ProjectClient projectClient = new ProjectClient();

        public SpecialPropertiesModel(ASPNetCore.Data.ASPNetCoreContext context)
        {
            _context = context;
            PropertyCodeDTO = new List<PropertyCodeDTO>();
        }

        public IList<PropertyCodeDTO> PropertyCodeDTO { get;set; }

        public async Task OnGetAsync()
        {
            var propertyCodes = await projectClient.GetPropertyCodesAsync();
            //Configure Mapper
            var config = new MapperConfiguration(mc => mc.CreateMap<ModelDesignFirst_L1.PropertyCode, PropertyCodeDTO>());
            //Map the objects
            var mapper = new Mapper(config);
            PropertyCodeDTO = mapper.Map<List<ModelDesignFirst_L1.PropertyCode>, List<PropertyCodeDTO>>(propertyCodes);
            foreach (var item in PropertyCodeDTO)
            {
                var props = await projectClient.GetPropertiesByCodeIDAsync(item.ID);
                item.Uses = props.Count();
            }
        }
    }
}
