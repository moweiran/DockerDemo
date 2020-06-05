using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public int MerchantId { get; set; }
        public string ProductName { get; set; }
        public int? CategoryId { get; set; }
        public int CoverImageId { get; set; }
        public string ProductImages { get; set; }
        public int Sort { get; set; }
        public bool IsHot { get; set; }
        public bool IsEnabled { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public string PlatformProductName { get; set; }
        public int? Status { get; set; }
        public int? BusinessSectionId { get; set; }
    }
}
