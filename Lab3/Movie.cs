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
    
    public partial class Movie
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
        public int PropertyID { get; set; }
    
        public virtual Property Property { get; set; }

        public static Movie CreateMovie(string fullPath, string movieName, DateTime creationDate, string corelatedEvent, string taggedPersons, string location, int duration)
        {

            return new Movie
            {
                ID = new Random().Next(1, 20000),
                FullPath = fullPath,
                MovieName = movieName,
                CreationDate = creationDate,
                Event = corelatedEvent,
                TaggedPersons = taggedPersons,
                Location = location,
                Duration = duration,
                FlgMoved = false,
                PropertyID = 11,
                Property = Property.CreateProperty(null, null, null)
            };
        }
    }
}
