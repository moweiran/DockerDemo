using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Fellow_Friends
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FriendUserId { get; set; }
        public int Status { get; set; }
        public string Reason { get; set; }
        public string Remark { get; set; }
        public bool DeleteMark { get; set; }
        public int CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int ModifyUserId { get; set; }
        public DateTime? ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
    }
}
