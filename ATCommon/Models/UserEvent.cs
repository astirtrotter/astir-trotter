using System;

namespace ATCommon.Models
{
    public class UserEvent
    {
        public string userId { get; set; }
        public DateTime at { get; set; }
        public string location { get; set; }
        public string details { get; set; }
    }
}
