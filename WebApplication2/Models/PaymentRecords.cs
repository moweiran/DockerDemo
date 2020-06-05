using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class PaymentRecords
    {
        public int PaymentRecordId { get; set; }
        public int? PayAccountId { get; set; }
        public int? PayAccountType { get; set; }
        public int? ReceiveAccountId { get; set; }
        public int? ReceiveAccountType { get; set; }
        public decimal? Amount { get; set; }
        public string PayComment { get; set; }
        public string ReceiveComment { get; set; }
        public int? RefId { get; set; }
        public int? BusinessType { get; set; }
        public DateTime? DeductionTime { get; set; }
        public int? Status { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
    }
}
