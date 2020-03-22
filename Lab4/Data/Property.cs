using System;
using System.Collections.Generic;
using System.Text;

namespace ProjTspNet.Data
{
    public class Property
    {
        public Guid ID { get; set; }
        public Guid MovieOrPhotoID { get; set; }
        public Guid PropCode { get; set; }
        public string PropDesc { get; set; }

        public Property()
        {
            ID = Guid.NewGuid();
        }
    
        public static Property CreateProperty(Guid movieOrPhotoID, Guid propCode, string propDesc)
        {
            return new Property
            {
                ID = Guid.NewGuid(),
                MovieOrPhotoID = movieOrPhotoID,
                PropCode = propCode,
                PropDesc = propDesc
            };
        }
    }
}
