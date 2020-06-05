using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class TaskWechatTemplateMessage
    {
        public int Id { get; set; }
        public string Touser { get; set; }
        public string TemplateId { get; set; }
        public string Data { get; set; }
        public int Status { get; set; }
        public string SendResult { get; set; }
        public DateTime? SendDateTime { get; set; }
        public int? SendTimes { get; set; }
        public bool DeleteMark { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string Url { get; set; }
    }
}
