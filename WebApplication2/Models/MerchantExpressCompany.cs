using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class MerchantExpressCompany
    {
        public int Id { get; set; }
        public int MerchantId { get; set; }
        public int ExpressCompanyId { get; set; }
        public string PrinterName { get; set; }
        public string PrinterIPAddress { get; set; }
    }
}
