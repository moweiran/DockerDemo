﻿using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Property
    {
        public int PropertyId { get; set; }
        public string PropertyValue { get; set; }
        public bool IsEnabled { get; set; }
        public string Remark { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
    }
}
