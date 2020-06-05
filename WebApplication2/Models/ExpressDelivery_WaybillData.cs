using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ExpressDelivery_WaybillData
    {
        public int Id { get; set; }
        public int ExpressDeliveryOrderId { get; set; }
        public string WaybillData { get; set; }
        public string CustomAreaData { get; set; }
    }
}
