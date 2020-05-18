using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore.Models
{
    public class PropertyDTO
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int PropertyCodeID { get; set; }
        public int MediaID { get; set; }
        public List<SelectListItem> Media { get; set; }
        public string Title { get; set; }
        //public virtual PropertyCodeDTO PropertyCode { get; set; }
    }
}
