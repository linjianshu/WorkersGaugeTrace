namespace MachineryProcessingDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("_EquipmentGroupBase")]
    public partial class C_EquipmentGroupBase
    {
        public long ID { get; set; }

        public long? WorkshopID { get; set; }

        [StringLength(1)]
        public string EquipmentGroupCode { get; set; }

        [StringLength(1)]
        public string EquipmentGroupName { get; set; }

        [StringLength(200)]
        public string GroupDescription { get; set; }

        public int? EquipmentNum { get; set; }

        public long? EquipmentType { get; set; }

        [StringLength(1)]
        public string EquipmentModel { get; set; }

        public bool? IsAvailable { get; set; }

        public DateTime? CreateTime { get; set; }

        public long? CreatorID { get; set; }

        public DateTime? LastModifiedTime { get; set; }

        public long? ModifierID { get; set; }

        [StringLength(200)]
        public string Remarks { get; set; }

        [StringLength(1)]
        public string Reserve1 { get; set; }

        [StringLength(1)]
        public string Reserve2 { get; set; }

        [StringLength(1)]
        public string Reserve3 { get; set; }
    }
}
