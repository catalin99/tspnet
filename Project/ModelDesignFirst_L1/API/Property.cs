using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    public partial class Property
    {
        public Property CreateProperty(string desc, int mediaID, int propCodeID)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var propCode = ctx.PropertyCodes.ToList().FirstOrDefault(a => a.ID == propCodeID);
                Property prop = new Property()
                {
                    ID = new Random().Next(1, 10000),
                    Description = desc,
                    MediaID = mediaID,
                    PropertyCodeID = propCodeID
                    //PropertyCode = propCode
                };
                ctx.Properties.Add(prop);
                ctx.SaveChanges();
                return prop;
            }
        }

        public List<Property> GetPropertiesByMediaID(int id)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var props = ctx.Properties.Where(a => a.MediaID == id).ToList();
                return props;
            }
        }

        public List<Property> GetPropertiesByCodeID(int id)
        {
            using (Model1Container ctx = new Model1Container())
            {
                var props = ctx.Properties.Where(a => a.PropertyCodeID == id).ToList();
                return props;
            }
        }
    }
}
