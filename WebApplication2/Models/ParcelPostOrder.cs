using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ParcelPostOrder
    {
        public int ParcelPostOrderId { get; set; }
        public string OrderNo { get; set; }
        public int PostMerchantId { get; set; }
        public int FromBusinessId { get; set; }
        public int FromBusinessType { get; set; }
        public int Status { get; set; }
        public bool DeleteMark { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public int ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
        public string BusinessCode { get; set; }
        public DateTime? TakeInDateTime { get; set; }
        public DateTime? ReceivedDateTime { get; set; }
        public int? SignUserId { get; set; }
        public string SignUserName { get; set; }
    }
}
