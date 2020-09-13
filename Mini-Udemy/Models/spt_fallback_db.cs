namespace Mini_Udemy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class spt_fallback_db
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string xserver_name { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime xdttm_ins { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime xdttm_last_ins_upd { get; set; }

        public short? xfallback_dbid { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string name { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short dbid { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short status { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short version { get; set; }
    }
}
