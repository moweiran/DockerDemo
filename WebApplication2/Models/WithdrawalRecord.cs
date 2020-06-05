using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class WithdrawalRecord
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int AccountType { get; set; }
        public decimal Amount { get; set; }
        public string ReceiveUserName { get; set; }
        public string OrderNo { get; set; }
        public bool IsWithdrawal { get; set; }
        public string Comment { get; set; }
        public int Status { get; set; }
        public string PaymentNo { get; set; }
        public int? RefId { get; set; }
        public DateTime? PaymentTime { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public decimal ActualArrivalAmount { get; set; }
        public decimal ServiceChargeAmount { get; set; }
        public decimal ServiceChargeRate { get; set; }
        public DateTime ApplyDateTime { get; set; }
        public string WechatWebOpenId { get; set; }
        public string WechatAppOpenId { get; set; }
        public decimal? CheckDateTime { get; set; }
        public int? CheckUserId { get; set; }
        public string CheckRemark { get; set; }
        public decimal? FinancePaidDateTime { get; set; }
        public decimal? FinanceUserId { get; set; }
        public string FinanceRemark { get; set; }
    }
}
