using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ProductMaterial
    {
        public int ProductMaterialId { get; set; }
        public int MerchantId { get; set; }
        public int? ProductId { get; set; }
        public string ProductTitle { get; set; }
        public int CoverImageId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
        public bool IsTop { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDisplayProduct { get; set; }
        public int? ProductPosition { get; set; }
        public string Source { get; set; }
        public int Sort { get; set; }
        public int Status { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
    }
}
