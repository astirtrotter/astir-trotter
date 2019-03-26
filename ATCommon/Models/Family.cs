using ATCommon.Models;
using System.Collections.Generic;

namespace ATCommon.Models
{
    public class Family
    {
        public string relation { get; set; }
        public User user { get; set; }
        public Family spouse { get; set; }
        public Family father { get; set; }
        public Family mother { get; set; }
        public List<Family> siblings { get; set; }
        public List<Family> children { get; set; }


        /// <summary>
        /// methods
        /// </summary>

        public Family Husband { get => user.IsMale ? this : spouse; }
        public Family Wife { get => !user.IsMale ? this : spouse; }
    }
}
