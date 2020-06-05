using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class ApplicationInfo
    {
        public int ApplicationInfoId { get; set; }
        public string AppName { get; set; }
        public string AppRemark { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public string WechatAppId { get; set; }
        public string WechatOfficeAccountAppId { get; set; }
        public string WechatMinAppId { get; set; }
    }
}
