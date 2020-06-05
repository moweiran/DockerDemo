using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ProductDistributionSku
    {
        public int ProductDistributionSkuId { get; set; }
        public int ProductDistributionId { get; set; }
        public int ProductId { get; set; }
        public int? ParentProductDistributionSkuId { get; set; }
        public int SkuId { get; set; }
        public decimal? BasePrice { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal SalesCount { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public decimal Stock { get; set; }
        public decimal CanUseStock { get; set; }
        public decimal FreezeStock { get; set; }
        public DateTime? DistributionDateTime { get; set; }
    }
}
