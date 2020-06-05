using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class FellowActivity
    {
        public int Id { get; set; }
        public int WebSiteId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
        public DateTime? ActivityDateTime { get; set; }
        public int JoinArea { get; set; }
        public string Address { get; set; }
        public int? LimitCount { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsSignUp { get; set; }
        public bool IsPayJoin { get; set; }
        public decimal? JoinPrice { get; set; }
        public int? JoinCount { get; set; }
        public decimal? Amount { get; set; }
        public decimal? SurplusAmount { get; set; }
        public decimal? WithdrawalAmount { get; set; }
        public int Status { get; set; }
        public string CheckContent { get; set; }
        public DateTime? CheckDateTime { get; set; }
        public bool DeleteMark { get; set; }
        public int CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int ModifyUserId { get; set; }
        public DateTime? ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
    }
}
