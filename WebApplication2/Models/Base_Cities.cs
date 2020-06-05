using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Base_Cities
    {
        public int Id { get; set; }
        public decimal CityId { get; set; }
        public decimal ProvinceId { get; set; }
        public string CityName { get; set; }
    }
}
