using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class FellowActivity_Apply
    {
        public int Id { get; set; }
        public int FellowActivityId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPhone { get; set; }
        public bool IsPayed { get; set; }
        public bool IsPayJoin { get; set; }
        public decimal? JoinPrice { get; set; }
        public bool IsSuccess { get; set; }
        public string OrderNo { get; set; }
        public string TransactionId { get; set; }
        public bool? IsRefundSuccess { get; set; }
        public bool? IsApplyRefund { get; set; }
        public string OpenId { get; set; }
        public string Comment { get; set; }
        public bool DeleteMark { get; set; }
        public int CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int ModifyUserId { get; set; }
        public DateTime? ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
    }
}
