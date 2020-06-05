using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class UserShopCart
    {
        public int UserShopCartId { get; set; }
        public int AccountId { get; set; }
        public int AccountType { get; set; }
        public int SkuId { get; set; }
        public int Quantity { get; set; }
        public DateTime AddDate { get; set; }
        public bool IsChecked { get; set; }
    }
}
