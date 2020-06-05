using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ExpressCompany
    {
        public int Id { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public string KuaidiNiaoCode { get; set; }
        public string CaiNiaoCode { get; set; }
    }
}
