using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Base_SysConfigure
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Category { get; set; }
        public string Value { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public string Remark { get; set; }
    }
}
