using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Base_Villages
    {
        public int Id { get; set; }
        public decimal ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public decimal CityId { get; set; }
        public string CityName { get; set; }
        public decimal CountyId { get; set; }
        public string CountyName { get; set; }
        public decimal TownId { get; set; }
        public string TownName { get; set; }
        public decimal VillageId { get; set; }
        public string VillageName { get; set; }
    }
}
