using System;

namespace ATCommon.Models
{
    public class UserEducationHistory
    {
        public string userId { get; set; }
        public DateTime periodStart { get; set; }
        public DateTime periodEnd { get; set; }
        public string schoolName { get; set; }
        public string schoolAddress { get; set; }
        public string degree { get; set; }
        public string details { get; set; }
    }
}
