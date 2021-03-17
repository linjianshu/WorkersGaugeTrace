namespace MachineryProcessingDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APS_ResLineTime
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string ProcessID { get; set; }

        [StringLength(50)]
        public string ProcedureID { get; set; }

        public int? Priority { get; set; }

        [StringLength(50)]
        public string Tag { get; set; }

        public DateTime? AccessibleTime { get; set; }

        public bool? IsAvailable { get; set; }

        public DateTime? CreateTime { get; set; }

        public long? CreatorID { get; set; }

        [StringLength(50)]
        public string Reserve1 { get; set; }

        [StringLength(50)]
        public string Reserve2 { get; set; }

        [StringLength(50)]
        public string Reserve3 { get; set; }
    }
}
