using ATCommon.Models;
using System.Collections.Generic;

namespace ATCommon.Responses
{
    public class SeedResponse : _Response
    {
        public List<_Gender> genders { get; set; }
        public List<_Party> parties { get; set; }
        public List<_Nationality> nationalities { get; set; }
        public List<_OriginClass> classOrigins { get; set; }
        public List<_OriginSocial> socialOrigins { get; set; }
        public List<_OriginNational> nationalOrigins { get; set; }
        public List<_Relationship> relationships { get; set; }
    }
}
