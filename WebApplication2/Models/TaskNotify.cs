using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class TaskNotify
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int AccountType { get; set; }
        public int BusinessType { get; set; }
        public int BusinessId { get; set; }
        public int NotifyType { get; set; }
        public int Status { get; set; }
        public DateTime? SendDateTime { get; set; }
        public int? SendTimes { get; set; }
        public string Remark { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public bool? IsSuccess { get; set; }
    }
}
