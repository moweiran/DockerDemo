using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ExpressDelivery_TraceData
    {
        public int ExpressDeliveryTraceDataId { get; set; }
        public int? ExpressDeliveryOrderId { get; set; }
        public int ExpressCompanyId { get; set; }
        public string ExpressNumberNo { get; set; }
        public string TraceData { get; set; }
        public DateTime? ModifyDateTime { get; set; }
    }
}
