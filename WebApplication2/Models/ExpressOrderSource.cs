using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ExpressOrderSource
    {
        public int ExpressOrderSourceId { get; set; }
        public string ExpressDeliveryOrderIds { get; set; }
        public int AccountId { get; set; }
        public int AccountType { get; set; }
        public int? ReceiveAccountId { get; set; }
        public int? ReceiveAccountType { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public decimal ReceiverProvinceId { get; set; }
        public decimal ReceiverCityId { get; set; }
        public decimal ReceiverCountyId { get; set; }
        public string ReceiverAddressDetail { get; set; }
        public string Remark { get; set; }
        public int? Status { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public string SerialNumber { get; set; }
        public decimal? Weight { get; set; }
        public string SenderName { get; set; }
        public string SenderPhone { get; set; }
        public decimal SenderProvinceId { get; set; }
        public decimal SenderCityId { get; set; }
        public decimal SenderCountyId { get; set; }
        public string SenderAddressDetail { get; set; }
        public decimal? Amount { get; set; }
        public bool? IsPayment { get; set; }
        public DateTime? PaymentDateTime { get; set; }
        public decimal? StateWeight { get; set; }
        public decimal? ExpressWeight { get; set; }
        public decimal? ExpressAmount { get; set; }
        public int? PaymentTradeType { get; set; }
    }
}
