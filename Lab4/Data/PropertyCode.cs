using System;
using System.Collections.Generic;
using System.Text;

namespace ProjTspNet.Data
{
    public class PropertyCode
    {
        public Guid ID { get; set; }
        public string Code { get; set; }

        public PropertyCode()
        {
            ID = Guid.NewGuid();
        }

        public static PropertyCode CreatePropertyCode(string code)
        {
            return new PropertyCode
            {
                ID = Guid.NewGuid(),
                Code = code
            };
        }
    }
}
