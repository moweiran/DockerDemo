using System;
using System.Collections.Generic;

namespace WebApplication2.Models
{
    public partial class Received5
    {
        public long Id { get; set; }
        public string Version { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public string Content { get; set; }
        public int Retries { get; set; }
        public DateTime Added { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public string StatusName { get; set; }
    }
}
