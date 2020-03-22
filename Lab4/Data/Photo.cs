using System;
using System.Collections.Generic;
using System.Text;

namespace ProjTspNet.Data
{
    public class Photo
    {
        public Guid ID { get; set; }
        public string FullPath { get; set; }
        public string PhotoName { get; set; }
        public DateTime CreationDate { get; set; }
        public string Event { get; set; }
        public string TaggedPersons { get; set; }
        public string Location { get; set; }
        public int Height { get; set; }
        public int Weitght { get; set; }
        public bool FlgMoved { get; set; }

        public Photo()
        {
            ID = Guid.NewGuid();
        }

        public static Photo CreatePhoto(string fullPath, string movieName, DateTime creationDate, string corelatedEvent, string taggedPersons, int height, int weight)
        {

            return new Photo
            {
                ID = Guid.NewGuid(),
                FullPath = fullPath,
                PhotoName = movieName,
                CreationDate = creationDate,
                Event = corelatedEvent,
                TaggedPersons = taggedPersons,
                Height = height,
                Weitght = weight,
                FlgMoved = false
            };
        }
    }
}
