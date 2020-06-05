using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ProductOrder
    {
        public int ProductOrderId { get; set; }
        public string ProductOrderNo { get; set; }
        public int MerchantId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public bool? IsPostFree { get; set; }
        public decimal? Postage { get; set; }
        public string Remark { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public decimal? ReceiverProvinceId { get; set; }
        public string ReceiverProvinceName { get; set; }
        public decimal? ReceiverCityId { get; set; }
        public string ReceiverCityName { get; set; }
        public decimal? ReceiverCountyId { get; set; }
        public string ReceiverCountyName { get; set; }
        public string ReceiverAddressDetail { get; set; }
        public int? PayType { get; set; }
        public DateTime? DeliveryDateTime { get; set; }
        public bool? IsReturnBack { get; set; }
        public int? Status { get; set; }
        public int? PaymentRecordId { get; set; }
        public DateTime? PayDateTime { get; set; }
        public DateTime? ExpressOrderCreateTime { get; set; }
        public DateTime? ReceiveDatetTime { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public decimal CostAmount { get; set; }
        public int? RefereeKey { get; set; }
        public string RecommendKey { get; set; }
        public decimal? RecommendProfit { get; set; }
        public int? OrderSource { get; set; }
        public string OutTradeNo { get; set; }
        public string OutRefundNo { get; set; }
        public int? PostMerchantId { get; set; }
        public int? DeliveryType { get; set; }
    }
}
