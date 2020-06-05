using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ProductDistribution
    {
        public int ProductDistributionId { get; set; }
        public int SupplierMerchantId { get; set; }
        public int DealerMerchantId { get; set; }
        public int DistributionMerchantId { get; set; }
        public int ParentProductDistributionId { get; set; }
        public int ProductId { get; set; }
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
