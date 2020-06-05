using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Base_Towns
    {
        public int Id { get; set; }
        public decimal TownId { get; set; }
        public decimal CountyId { get; set; }
        public string TownName { get; set; }
    }
}
