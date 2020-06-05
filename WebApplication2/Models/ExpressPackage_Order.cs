using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ExpressPackage_Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ExpressMerchantId { get; set; }
        public decimal? Amount { get; set; }
        public int Status { get; set; }
        public string Remark { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public DateTime? ReceiveDateTime { get; set; }
        public int? ReceivedType { get; set; }
        public string ExpressNumber { get; set; }
        public int? ParcelPostOrderId { get; set; }
        public int? NotifyType { get; set; }
        public bool? NotifyStatus { get; set; }
        public int? ImageFileId { get; set; }
        public int? SignUserId { get; set; }
        public string SignUserName { get; set; }
        public int? PostMerchantId { get; set; }
        public int? FromBusinessId { get; set; }
        public int? FromBusinessType { get; set; }
        public bool? IsFirst { get; set; }
        public string UserPhone { get; set; }
        public int? ExpressCompanyId { get; set; }
    }
}
