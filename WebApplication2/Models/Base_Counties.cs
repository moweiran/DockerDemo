using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Base_Counties
    {
        public int Id { get; set; }
        public decimal CountyId { get; set; }
        public decimal CityId { get; set; }
        public string CountyName { get; set; }
    }
}
