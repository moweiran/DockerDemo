using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class WarehouseOrder
    {
        public int Id { get; set; }
        public int BusinessMerchantId { get; set; }
        public int WarehouseMerchantId { get; set; }
        public int ExpressCompanyId { get; set; }
        public int? DeliveryMerchantId { get; set; }
        public decimal Amount { get; set; }
        public decimal? DeliveryAmount { get; set; }
        public int? BusinessType { get; set; }
        public string BusinessCode { get; set; }
        public int Status { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public int? TransitMerchantId { get; set; }
        public bool? IsDeliveryReminder { get; set; }
        public int? DeliveryReminderStatus { get; set; }
        public string ReminderArea { get; set; }
        public string ReminderPhone { get; set; }
        public bool? IsHasProblem { get; set; }
        public int? ProblemType { get; set; }
        public int? ProblemStatus { get; set; }
        public int? InputMerchantId { get; set; }
        public int? CountyMerchantId { get; set; }
        public string ProblemFileIds { get; set; }
        public bool? IsCashOnDelivery { get; set; }
        public decimal? CashOnDeliveryAmount { get; set; }
        public int? CashOnDeliveryStatus { get; set; }
        public int? CashOnDeliveryMerchantId { get; set; }
        public string CashOnDeliveryFileIds { get; set; }
        public string CashOnDeliveryReceiveFileIds { get; set; }
        public int? CashOnDeliveryNotifyStatus { get; set; }
        public string CashOnDeliveryOutTradeNo { get; set; }
        public int? CashOnDeliveryTradeType { get; set; }
        public DateTime? CashOnDeliveryNotifyDate { get; set; }
        public DateTime? CashOnDeliveryReceiveDate { get; set; }
        public DateTime? ProblemDate { get; set; }
        public DateTime? ReminderDate { get; set; }
        public int? ReminderNotifyStatus { get; set; }
        public bool? IsSign { get; set; }
        public int? SignType { get; set; }
        public int? SignStatus { get; set; }
        public DateTime? SignDateTime { get; set; }
        public int? SignNotifyStatus { get; set; }
        public DateTime? SignNotifyDateTime { get; set; }
        public int? SignNotifyType { get; set; }
        public int? SignNotifyUserId { get; set; }
        public bool? IsClear { get; set; }
        public decimal? ClearAmount { get; set; }
    }
}
