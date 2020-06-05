using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class PaymentUnifiedOrder
    {
        public int PaymentUnifiedOrderId { get; set; }
        public string AccessKey { get; set; }
        public string PaymentUnifiedOrderNo { get; set; }
        public string OutTradeNo { get; set; }
        public decimal TotalFee { get; set; }
        public int TradeType { get; set; }
        public string Body { get; set; }
        public string NotifyUrl { get; set; }
        public string FrontNotifyUrl { get; set; }
        public string Attach { get; set; }
        public int? AccountId { get; set; }
        public int? AccountType { get; set; }
        public string AuthCode { get; set; }
        public string Detail { get; set; }
        public string DeviceInfo { get; set; }
        public string OpenId { get; set; }
        public int? ProductId { get; set; }
        public string ResultQueryUrl { get; set; }
        public string WechatH5PayRedirectUrl { get; set; }
        public int PayStatus { get; set; }
        public int Status { get; set; }
        public int SendTimes { get; set; }
        public string WechatAppId { get; set; }
        public int? ErrCode { get; set; }
        public string ErrMsg { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public int? FromBusinessType { get; set; }
    }
}
