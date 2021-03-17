namespace MachineryProcessingDemo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WF_NodeButtonRelation
    {
        [Key]
        [StringLength(50)]
        public string NodeButtonRelationId { get; set; }

        [StringLength(50)]
        public string FlowNodeId { get; set; }

        [StringLength(50)]
        public string ButtonId { get; set; }

        public int? IsBack { get; set; }

        public int? Enabled { get; set; }

        public int? DeleteMark { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateUserId { get; set; }

        [StringLength(50)]
        public string CreateUserName { get; set; }

        public DateTime? ModifyDate { get; set; }

        [StringLength(50)]
        public string ModifyUserId { get; set; }

        [StringLength(50)]
        public string ModifyUserName { get; set; }
    }
}
