using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class RechargeOrder
    {
        public int RechargeOrderId { get; set; }
        public string RechargeOrderNo { get; set; }
        public int AccountId { get; set; }
        public int AccountType { get; set; }
        public decimal Amount { get; set; }
        public int TradeType { get; set; }
        public int OrderSouce { get; set; }
        public int Status { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
    }
}
