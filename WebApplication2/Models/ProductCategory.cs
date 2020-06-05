using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ProductCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int ParentId { get; set; }
        public int? SortIndex { get; set; }
        public string Remark { get; set; }
        public bool? IsEnabled { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
    }
}
