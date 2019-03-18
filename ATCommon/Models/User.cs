using System;

namespace ATCommon.Models
{
    public class User
    {
        public string id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nickName { get; set; }
        public bool gender { get; set; }
        public DateTime birthday { get; set; }
        public string birthPlace { get; set; }
        public string address { get; set; }
        public string classOrigin { get; set; }
        public string socialOrigin { get; set; }
        public string nationalOrigin { get; set; }
        public string nationality { get; set; }
        public string picture { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string moreContactInfo { get; set; }
        public string fatherId { get; set; }
        public string motherId { get; set; }
        public string spouseId { get; set; }
    }
}
