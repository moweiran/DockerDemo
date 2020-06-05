using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class FriendShip
    {
        public int Id { get; set; }
        public int WebsiteId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public int? LikeCount { get; set; }
        public int? CommentCount { get; set; }
        public bool DeleteMark { get; set; }
        public int CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int ModifyUserId { get; set; }
        public DateTime? ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
    }
}
