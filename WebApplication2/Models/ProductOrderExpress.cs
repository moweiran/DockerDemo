using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ProductOrderExpress
    {
        public int ProductOrderExpressId { get; set; }
        public int ProductOrderId { get; set; }
        public int ExpressDeliveryOrderId { get; set; }
        public string ExpressNo { get; set; }
        public string ExpressCompanyName { get; set; }
        public string ExpressCompanyCode { get; set; }
    }
}
