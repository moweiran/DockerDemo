using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class MerchantsExpressPackage
    {
        public int Id { get; set; }
        public int MerchantId { get; set; }
        public decimal Amount { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
    }
}
