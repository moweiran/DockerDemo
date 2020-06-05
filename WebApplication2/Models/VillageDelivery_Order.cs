using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class VillageDelivery_Order
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public string SerialNumber { get; set; }
        public int AccountId { get; set; }
        public int AccountType { get; set; }
        public string SenderName { get; set; }
        public string SenderPhone { get; set; }
        public decimal SenderTownId { get; set; }
        public decimal SenderVillageId { get; set; }
        public string SenderAddressDetail { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public decimal ReceiverTownId { get; set; }
        public decimal? ReceiverVillageId { get; set; }
        public string ReceiverAddressDetail { get; set; }
        public int DeliveryType { get; set; }
        public int OrderType { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Amount { get; set; }
        public string Remark { get; set; }
        public int? ReceivedType { get; set; }
        public DateTime? ReceivedDateTime { get; set; }
        public int Status { get; set; }
        public int? OrderSouce { get; set; }
        public int? FromBusinessType { get; set; }
        public int? FromBusinessId { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public int? TownDriverMerchantId { get; set; }
        public int? SenderDriverMerchantId { get; set; }
        public int? DeliveryCenterMerchantId { get; set; }
        public int? ReceiverDriverMerchantId { get; set; }
        public DateTime? TownDriverTakeOrderTime { get; set; }
        public DateTime? SenderDriverTakeOrderTime { get; set; }
        public DateTime? ReceiverDriverTakeOrderTime { get; set; }
    }
}
