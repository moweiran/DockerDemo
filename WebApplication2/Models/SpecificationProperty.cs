using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class SpecificationProperty
    {
        public int SpecificationPropertyId { get; set; }
        public int SpecificationId { get; set; }
        public int PropertyId { get; set; }
    }
}
