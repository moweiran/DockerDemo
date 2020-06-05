using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Base_Website
    {
        public int Id { get; set; }
        public string WebsiteName { get; set; }
        public string WebsiteCode { get; set; }
        public string WebsiteAddress { get; set; }
        public decimal CountyId { get; set; }
        public bool IsEnabled { get; set; }
        public bool DeleteMark { get; set; }
        public int CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int ModifyUserId { get; set; }
        public DateTime? ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
    }
}
