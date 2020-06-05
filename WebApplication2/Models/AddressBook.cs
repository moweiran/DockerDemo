using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class AddressBook
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int AccountType { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public decimal? ProvinceId { get; set; }
        public decimal? CityId { get; set; }
        public decimal? CountyId { get; set; }
        public decimal? TownId { get; set; }
        public decimal? VillageId { get; set; }
        public string AddressDetail { get; set; }
        public int? IdCardFront { get; set; }
        public int? IdCardReverse { get; set; }
        public int BookType { get; set; }
        public bool IsDefault { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public int? PostMerchantId { get; set; }
    }
}
