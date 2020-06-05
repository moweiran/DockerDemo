using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ProductOrderDetail
    {
        public int ProductOrderDetailId { get; set; }
        public int ProductOrderId { get; set; }
        public int ProductId { get; set; }
        public string SkuName { get; set; }
        public string ProductName { get; set; }
        public int SkuId { get; set; }
        public int? ProductDistributionSkuId { get; set; }
        public int? DealerMerchantId { get; set; }
        public decimal Price { get; set; }
        public decimal CostPrice { get; set; }
        public decimal? DealerPrice { get; set; }
        public decimal? DealerAmount { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public decimal CostAmount { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public decimal? ShareProfit { get; set; }
    }
}
