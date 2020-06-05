using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class AccountRecords
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int AccountType { get; set; }
        public decimal Amount { get; set; }
        public int BusinessType { get; set; }
        public long RefId { get; set; }
        public string Comment { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public int? CommentType { get; set; }
        public int? RefType { get; set; }
    }
}
