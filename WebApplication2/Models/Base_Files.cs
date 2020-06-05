using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Base_Files
    {
        public int Id { get; set; }
        public int WebsiteId { get; set; }
        public int? UserId { get; set; }
        public string FileName { get; set; }
        public int FileType { get; set; }
        public int? RefId { get; set; }
        public string AbsPath { get; set; }
        public string ThumbPath { get; set; }
        public string ETag { get; set; }
        public string Comment { get; set; }
        public bool DeleteMark { get; set; }
        public int CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int ModifyUserId { get; set; }
        public DateTime? ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public string ThumbETag { get; set; }
    }
}
