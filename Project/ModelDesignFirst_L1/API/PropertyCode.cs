using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    public partial class PropertyCode
    {
        public PropertyCode CreatePropertyCode(string code)
        {
            using (Model1Container ctx = new Model1Container())
            {
                PropertyCode propCode = new PropertyCode(code);
                ctx.PropertyCodes.Add(propCode);
                ctx.SaveChanges();
                return propCode;
            }
        }

        public bool DeletePropertyCode(int id)
        {
            using (Model1Container ctx = new Model1Container())
            {
                PropertyCode propCode = ctx.PropertyCodes.FirstOrDefault(a => a.ID == id);
                if (propCode != default(PropertyCode))
                {
                    ctx.PropertyCodes.Remove(propCode);
                    ctx.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public List<PropertyCode> GetPropertyCodes()
        {
            using (Model1Container ctx = new Model1Container())
            {
                List<PropertyCode> propCodes = ctx.PropertyCodes.ToList();
                if (propCodes.Count > 0)
                {
                    return propCodes;
                }
                return null;
            }
        }
    }
}
