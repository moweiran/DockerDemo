using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class FriendShip_Comment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FriendShipId { get; set; }
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
