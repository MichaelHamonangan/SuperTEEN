namespace SuperTEEN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TbKesehatan")]
    public partial class TbKesehatan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column("Nama_Modul")]
        [Required]
        [StringLength(50)]
        public string Nama_Modul { get; set; }

        public int Durasi { get; set; }

        public int Exp_Gain { get; set; }

        public int Jumlah_Task { get; set; }

        [Required]
        [StringLength(200)]
        public string Task_1 { get; set; }

        public int drTask_1 { get; set; }

        [StringLength(200)]
        public string Task_2 { get; set; }

        public int? drTask_2 { get; set; }

        [StringLength(200)]
        public string Task_3 { get; set; }

        public int? drTask_3 { get; set; }

        [StringLength(200)]
        public string Task_4 { get; set; }

        public int? drTask_4 { get; set; }

        [StringLength(200)]
        public string Task_5 { get; set; }

        public int? drTask_5 { get; set; }

        [StringLength(200)]
        public string Task_6 { get; set; }

        public int? drTask_6 { get; set; }

        [StringLength(200)]
        public string Task_7 { get; set; }

        public int? drTask_7 { get; set; }

        [StringLength(200)]
        public string Task_8 { get; set; }

        public int? drTask_8 { get; set; }

        [StringLength(200)]
        public string Task_9 { get; set; }

        public int? drTask_9 { get; set; }
    }
}
