namespace SuperTEEN
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        [StringLength(15)]

        public string Username { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        public int Level { get; set; }

        public int Current_Exp { get; set; }
    }
}
