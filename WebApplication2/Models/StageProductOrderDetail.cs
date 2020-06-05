using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class StageProductOrderDetail
    {
        public int StageProductOrderDetailId { get; set; }
        public long StageProductOrderId { get; set; }
        public int SkuId { get; set; }
        public string SkuName { get; set; }
        public decimal Price { get; set; }
        public decimal CostPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; }
        public decimal CostAmount { get; set; }
        public decimal? Profit { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
    }
}
