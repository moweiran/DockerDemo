using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class VillageDelivery_FeeStandard
    {
        public int Id { get; set; }
        public string FeeName { get; set; }
        public string FeeKey { get; set; }
        public int FeeType { get; set; }
        public decimal StartAmount { get; set; }
        public decimal? StartWeight { get; set; }
        public decimal? ContinueWeight { get; set; }
        public decimal? ContinuePrice { get; set; }
    }
}
