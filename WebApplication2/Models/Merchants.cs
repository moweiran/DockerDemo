using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Merchants
    {
        public int Id { get; set; }
        public int WebsiteId { get; set; }
        public string MerchantName { get; set; }
        public string MerchantNo { get; set; }
        public int? MerchantLogoId { get; set; }
        public int AdminId { get; set; }
        public string Linkman { get; set; }
        public string Mobile { get; set; }
        public string BusinessScope { get; set; }
        public decimal TownId { get; set; }
        public decimal VillageId { get; set; }
        public string PayPassword { get; set; }
        public decimal? CanUseAmount { get; set; }
        public decimal? FreezeAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public int? FavoriteCount { get; set; }
        public int Status { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public string OpenId { get; set; }
        public string AppOpenId { get; set; }
        public string Address { get; set; }
    }
}
