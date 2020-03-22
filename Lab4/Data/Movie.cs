using System;
using System.Collections.Generic;
using System.Text;

namespace ProjTspNet.Data
{
    public class Movie
    {
        public Guid ID { get; set; }
        public string FullPath { get; set; }
        public string MovieName { get; set; }
        public DateTime CreationDate { get; set; }
        public string Event { get; set; }
        public string TaggedPersons { get; set; }
        public string Location { get; set; }
        public int Duration { get; set; }
        public bool FlgMoved { get; set; }

        public Movie()
        {
            ID = Guid.NewGuid();
        }

        public static Movie CreateMovie(string fullPath, string movieName, DateTime creationDate, string corelatedEvent, string taggedPersons, int duration)
        {

            return new Movie
            {
                ID = Guid.NewGuid(),
                FullPath = fullPath,
                MovieName = movieName,
                CreationDate = creationDate,
                Event = corelatedEvent,
                TaggedPersons = taggedPersons,
                Duration = duration,
                FlgMoved = false
            };
        }
    }
}
