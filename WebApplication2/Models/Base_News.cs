using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Base_News
    {
        public int Id { get; set; }
        public int WebSiteId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
        public int Status { get; set; }
        public bool DeleteMark { get; set; }
        public int CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int ModifyUserId { get; set; }
        public DateTime? ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public int? CoverImageId { get; set; }
        public string Source { get; set; }
        public bool? IsHot { get; set; }
    }
}
