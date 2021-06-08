using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnblockMe.Models.Entities
{
    public class Vehicle:BaseEntity
    {
        public string RegPlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
