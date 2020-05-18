using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore.Models
{
    public class PropertyCodeDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PropertyCodeDTO()
        {
            this.Properties = new HashSet<PropertyDTO>();
        }

        public PropertyCodeDTO(string code)
        {
            this.ID = new Random().Next(1, 30000);
            this.Properties = new HashSet<PropertyDTO>();
            this.Code = code;
        }

        public int ID { get; set; }
        public string Code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PropertyDTO> Properties { get; set; }
    }
}
