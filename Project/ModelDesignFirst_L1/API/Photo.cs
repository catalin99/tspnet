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
                    ctx.Photos.Remove(Photo);
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
                return ctx.Photos.ToList();
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
    }
}
