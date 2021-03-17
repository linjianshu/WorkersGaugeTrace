using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersGaugeTrace
{
    public class KitDto
    {
        public long ID { get; set; }

        public long? KitID { get; set; }

        public string KitCode { get; set; }

        public string KitBornCode { get; set; }

        public string KitName { get; set; }

        public int? ApplicanceType { get; set; }
        public string StaffCode { get; set; }

        public string StaffName { get; set; }

        public int? PositionType { get; set; }

        public long? PositionID { get; set; }

        public string PositionCode { get; set; }

        public string PositionName { get; set; }

        public bool? IsAvailable { get; set; }

        public DateTime? CreateTime { get; set; }

        public long? CreatorID { get; set; }

        public DateTime? LastModifiedTime { get; set; }

        public long? ModifierID { get; set; }

        public string Remarks { get; set; }

        public string Reserve1 { get; set; }

        public string Reserve2 { get; set; }

        public string Reserve3 { get; set; }
    }
}
