using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Base_UserInfo
    {
        public int Id { get; set; }
        public int WebsiteId { get; set; }
        public string UserName { get; set; }
        public string UserPhone { get; set; }
        public string RealName { get; set; }
        public string UserPwd { get; set; }
        public string NickName { get; set; }
        public string UserEmail { get; set; }
        public byte? Sex { get; set; }
        public byte? Age { get; set; }
        public string JobIntro { get; set; }
        public decimal? NowCityId { get; set; }
        public decimal? NowProvinceId { get; set; }
        public decimal? HomeVillageId { get; set; }
        public decimal? HomeTownId { get; set; }
        public int? IndustryId { get; set; }
        public int UserType { get; set; }
        public bool IsCertificate { get; set; }
        public string InviterKey { get; set; }
        public string RecommendKey { get; set; }
        public bool IsCompleted { get; set; }
        public string MoodContent { get; set; }
        public string WeiXinOpenId { get; set; }
        public string WeiXinAppOpenId { get; set; }
        public int? FriendCount { get; set; }
        public decimal? CanUseAmount { get; set; }
        public decimal? FreezeAmount { get; set; }
        public decimal? TotalAmount { get; set; }
        public string IdentityCard { get; set; }
        public int? IdentityStatus { get; set; }
        public int? MerchantId { get; set; }
        public int? MerchantUserType { get; set; }
        public bool DeleteMark { get; set; }
        public int? CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ModifyUserId { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public string ModifyUserName { get; set; }
        public string WechatUnionId { get; set; }
        public int? UserLevelId { get; set; }
        public string WechatMinAppOpenId { get; set; }
        public bool? IsPackagePickUp { get; set; }
    }
}
