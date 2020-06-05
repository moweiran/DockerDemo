using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ProductSku
    {
        public int SkuId { get; set; }
        public string SkuName { get; set; }
        public string SkuKey { get; set; }
        public int? CoverImageId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal BasePrice { get; set; }
        public decimal TradePrice { get; set; }
        public decimal Stock { get; set; }
        public decimal CanUseStock { get; set; }
        public decimal FreezeStock { get; set; }
        public decimal SalesCount { get; set; }
        public int Sort { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsHot { get; set; }
        public bool IsSpecialPrice { get; set; }
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
