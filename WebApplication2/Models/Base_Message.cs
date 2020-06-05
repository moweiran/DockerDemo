using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Base_Message
    {
        public int Id { get; set; }
        public int WebsiteId { get; set; }
        public string SendUserName { get; set; }
        public int SendUserType { get; set; }
        public int SendUserId { get; set; }
        public int ReceiveUserId { get; set; }
        public int ReceiveUserType { get; set; }
        public int MessageType { get; set; }
        public string MsgTitle { get; set; }
        public string MsgContent { get; set; }
        public int? Param { get; set; }
        public int? Param1 { get; set; }
        public int? Param2 { get; set; }
        public int? Param3 { get; set; }
        public int? Param4 { get; set; }
        public int? Param5 { get; set; }
        public int? Param6 { get; set; }
        public int? Param7 { get; set; }
        public int? Param8 { get; set; }
        public int? Param9 { get; set; }
        public int Status { get; set; }
        public bool DeleteMark { get; set; }
        public int CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int ModifyUserId { get; set; }
        public DateTime? ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
    }
}
