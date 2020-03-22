//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelDesignFirst_L1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Photo
    {
        public int ID { get; set; }
        public string FullPath { get; set; }
        public string PhotoName { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string Event { get; set; }
        public string TaggedPersons { get; set; }
        public string Location { get; set; }
        public bool FlgMoved { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int PropertyID { get; set; }
    
        public virtual Property Property { get; set; }
        public static Photo CreatePhoto(string fullPath, string movieName, DateTime creationDate, string corelatedEvent, string taggedPersons, string location, int height, int weight)
        {

            return new Photo
            {
                ID = new Random().Next(10,10000),
                FullPath = fullPath,
                PhotoName = movieName,
                CreationDate = creationDate,
                Event = corelatedEvent,
                TaggedPersons = taggedPersons,
                Location = location,
                Height = height,
                Weight = weight,
                FlgMoved = false,
                PropertyID = 11,
                Property = Property.CreateProperty(null, null, null)
            };
        }
    }
}