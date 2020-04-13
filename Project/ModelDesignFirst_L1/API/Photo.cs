using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    public partial class Photo
    {
        public bool DeletePhoto(int id)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var Photo = ctx.Photos.FirstOrDefault(u => u.ID == id);
                if (Photo != default(Photo))
                {
                    Photo.FlgMoved = true;
                    ctx.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public Photo GetPhotoById(int id)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var Photo = ctx.Photos.FirstOrDefault(m => m.ID == id);
                if (Photo != default(Photo))
                    return Photo;
                return null;
            }
        }

        public List<Photo> GetAllPhotos()
        {
            using (Model1Container ctx = new Model1Container())
            {
                return ctx.Photos.Where(p=>p.FlgMoved==false).ToList();
            }
        }

        public Photo UpdatePhoto(int id, string fullPath, string PhotoName, DateTime creationDate, string corelatedEvent, string taggedPersons, string location, int height, int weight)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var Photo = ctx.Photos.FirstOrDefault(m => m.ID == id);
                Photo.FullPath = fullPath;
                Photo.PhotoName = PhotoName;
                Photo.CreationDate = creationDate;
                Photo.Event = corelatedEvent;
                Photo.TaggedPersons = taggedPersons;
                Photo.Location = location;
                Photo.Height = height;
                Photo.Weight = weight;
                ctx.SaveChanges();
                return Photo;
            }
        }

        public Photo CreatePhoto(string fullPath, string PhotoName, DateTime creationDate, string corelatedEvent, string taggedPersons, string location, int height, int weight)
        {
            using (Model1Container ctx = new Model1Container())
            {
                Photo photo = new Photo()
                {
                    ID = new Random().Next(1,10000),
                    FullPath = fullPath,
                    PhotoName = PhotoName,
                    CreationDate = creationDate,
                    Event = corelatedEvent,
                    TaggedPersons = taggedPersons,
                    Location = location,
                    Height = height,
                    Weight = weight
                };
                ctx.Photos.Add(photo);
                ctx.SaveChanges();
                return photo;
            }
        }
    }
}
