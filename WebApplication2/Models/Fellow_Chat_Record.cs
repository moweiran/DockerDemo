using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Fellow_Chat_Record
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ReceiverUserId { get; set; }
        public bool IsRead { get; set; }
        public string MsgContent { get; set; }
        public DateTime? ReadDateTime { get; set; }
        public bool DeleteMark { get; set; }
        public int CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int ModifyUserId { get; set; }
        public DateTime? ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
    }
}
