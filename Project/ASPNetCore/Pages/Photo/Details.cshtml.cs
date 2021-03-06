﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly ASPNetCore.Data.ASPNetCoreContext _context;
        ProjectClient projectClient = new ProjectClient();


        public DetailsModel(ASPNetCore.Data.ASPNetCoreContext context)
        {
            _context = context;
        }

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
            PhotoDTO.Props = new List<Tuple<string, string>>();
            var props = await projectClient.GetPropertiesByMediaIDAsync((int)id);
            var codes = await projectClient.GetPropertyCodesAsync();
            foreach (var prop in props)
            {
                var propCode = codes.FirstOrDefault(c => c.ID == prop.PropertyCodeID);
                PhotoDTO.Props.Add(new Tuple<string, string>(propCode.Code, prop.Description));
            }

            if (PhotoDTO == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
