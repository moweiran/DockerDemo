using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class VillageDelivery_OrderTrace
    {
        public int Id { get; set; }
        public int VillageDeliveryOrderId { get; set; }
        public int AccountId { get; set; }
        public int AccountType { get; set; }
        public int Status { get; set; }
        public bool IsDriver { get; set; }
        public string Remark { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
