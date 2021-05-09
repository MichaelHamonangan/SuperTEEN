namespace SuperTEEN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TbMotivasi")]
    public partial class TbMotivasi
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nama_Modul { get; set; }

        public int Exp_Gain { get; set; }

        [Required]
        [StringLength(500)]
        public string Task { get; set; }
    }
}
