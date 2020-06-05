using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ProductDistributionOrderDetail
    {
        public int ProductDistributionOrderDetailId { get; set; }
        public long ProductDistributionOrderId { get; set; }
        public int ProductDistributionId { get; set; }
        public int ParentProductDistributionId { get; set; }
        public int ProductDistributionSkuId { get; set; }
        public int? ParentProductDistributionSkuId { get; set; }
        public int SkuId { get; set; }
        public string SkuName { get; set; }
        public decimal Quantity { get; set; }
        public decimal DistributionPrice { get; set; }
        public decimal DistributionAmount { get; set; }
        public decimal DistributionCostPrice { get; set; }
        public decimal DistributionCostAmount { get; set; }
        public decimal DistributionProfit { get; set; }
        public decimal DealerPrice { get; set; }
        public decimal DealerAmount { get; set; }
        public decimal DealerCostPrice { get; set; }
        public decimal DealerCostAmount { get; set; }
        public decimal DealerProfit { get; set; }
        public decimal SupplierPrice { get; set; }
        public decimal SupplierAmount { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
    }
}
