using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ProductSkuProperty
    {
        public int ProductSkuPropertyId { get; set; }
        public int SkuId { get; set; }
        public int ProductId { get; set; }
        public int ProductSpecificationId { get; set; }
        public int SpecificationId { get; set; }
        public int SpecificationPropertyId { get; set; }
        public int PropertyId { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
    }
}
