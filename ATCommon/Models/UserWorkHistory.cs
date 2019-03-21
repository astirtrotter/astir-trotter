using System;

namespace ATCommon.Models
{
    public class UserWorkHistory
    {
        public string userId { get; set; }
        public DateTime periodStart { get; set; }
        public DateTime periodEnd { get; set; }
        public string companyName { get; set; }
        public string companyAddress { get; set; }
        public string position { get; set; }
        public string details { get; set; }
    }
}
