using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ProductDistributionOrder
    {
        public long ProductDistributionOrderId { get; set; }
        public string OrderNo { get; set; }
        public string BatchOrderNo { get; set; }
        public string OutTradeNo { get; set; }
        public string OutRefundNo { get; set; }
        public int SupplierMerchantId { get; set; }
        public int DealerMerchantId { get; set; }
        public int DistributionMerchantId { get; set; }
        public int? UserId { get; set; }
        public string WechatOpenId { get; set; }
        public decimal DistributionAmount { get; set; }
        public decimal DistributionCostAmount { get; set; }
        public decimal DistributionProfit { get; set; }
        public decimal DealerAmount { get; set; }
        public decimal DealerCostAmount { get; set; }
        public decimal DealerProfit { get; set; }
        public decimal SupplierAmount { get; set; }
        public int? OrderSource { get; set; }
        public int? PayType { get; set; }
        public DateTime? PayDateTime { get; set; }
        public bool? IsRefund { get; set; }
        public DateTime? RefundDateTime { get; set; }
        public int? RefundStatus { get; set; }
        public int? Status { get; set; }
        public string Remark { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
    }
}
