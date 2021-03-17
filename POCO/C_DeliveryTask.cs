namespace MachineryProcessingDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_DeliveryTask")]
    public partial class C_DeliveryTask
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string DeliveryCode { get; set; }

        public DateTime? DeliverTime { get; set; }

        [StringLength(50)]
        public string StaffCode { get; set; }

        public long? CompanyID { get; set; }

        [StringLength(50)]
        public string ContactsName { get; set; }

        [StringLength(50)]
        public string ContactsPhone { get; set; }

        public bool? IsAvailable { get; set; }

        public DateTime? CreateTime { get; set; }

        public long? CreatorID { get; set; }

        public DateTime? LastModifiedTime { get; set; }

        public long? ModifierID { get; set; }

        [StringLength(200)]
        public string Remarks { get; set; }

        [StringLength(50)]
        public string Reserve1 { get; set; }

        [StringLength(50)]
        public string Reserve2 { get; set; }

        [StringLength(50)]
        public string Reserve3 { get; set; }
    }
}
