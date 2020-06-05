using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ExpressDelivery_Order
    {
        public int Id { get; set; }
        public string ExpressOrderNo { get; set; }
        public string SerialNumber { get; set; }
        public int? ExpressCompanyId { get; set; }
        public string ExpressNumber { get; set; }
        public int AccountId { get; set; }
        public int AccountType { get; set; }
        public int? MerchantId { get; set; }
        public string SenderName { get; set; }
        public string SenderPhone { get; set; }
        public int? SenderIdCardFront { get; set; }
        public int? SenderIdCardReverse { get; set; }
        public decimal SenderProvinceId { get; set; }
        public decimal SenderCityId { get; set; }
        public decimal SenderCountyId { get; set; }
        public string SenderAddressDetail { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public decimal ReceiverProvinceId { get; set; }
        public decimal ReceiverCityId { get; set; }
        public decimal ReceiverCountyId { get; set; }
        public string ReceiverAddressDetail { get; set; }
        public string Remark { get; set; }
        public decimal? Amount { get; set; }
        public bool IsPayed { get; set; }
        public int Status { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public decimal? ExpressAmount { get; set; }
        public int? FromBusinessType { get; set; }
        public int? FromBusinessId { get; set; }
        public decimal? Weight { get; set; }
        public bool? IsFinished { get; set; }
        public DateTime? DeliveryDateTime { get; set; }
        public DateTime? FinishedDateTime { get; set; }
        public string TrackData { get; set; }
        public bool? IsReconciliation { get; set; }
        public int? OrderPrintType { get; set; }
        public decimal? PaymentExpressAmount { get; set; }
        public decimal? SuperAreaAmount { get; set; }
        public int? ReconciliationStatus { get; set; }
        public string SenderProvinceName { get; set; }
        public string SenderCityName { get; set; }
        public string SenderCountyName { get; set; }
        public string ReceiverProvinceName { get; set; }
        public string ReceiverCityName { get; set; }
        public string ReceiverCountyName { get; set; }
    }
}
