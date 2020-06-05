using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class StageProductOrder
    {
        public long StageProductOrderId { get; set; }
        public string OrderNo { get; set; }
        public string BatchOrderNo { get; set; }
        public string OutTradeNo { get; set; }
        public string OutRefundNo { get; set; }
        public int SupplierMerchantId { get; set; }
        public int StageMerchantId { get; set; }
        public int? UserId { get; set; }
        public string WechatOpenId { get; set; }
        public decimal Amount { get; set; }
        public decimal CostAmount { get; set; }
        public decimal? Profit { get; set; }
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
