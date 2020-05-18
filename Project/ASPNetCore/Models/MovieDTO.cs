using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore.Models
{
    public class MovieDTO
    {
        public int ID { get; set; }
        public string FullPath { get; set; }
        public string MovieName { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string Event { get; set; }
        public string TaggedPersons { get; set; }
        public string Location { get; set; }
        public bool FlgMoved { get; set; }
        public int Duration { get; set; }
    }
}
