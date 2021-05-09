using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SuperTEEN
{
    public partial class DatabaseModul : DbContext
    {
        public DatabaseModul()
            : base("name=DatabaseModul")
        {
        }

        public virtual DbSet<TbBelajar> TbBelajars { get; set; }
        public virtual DbSet<TbKesehatan> TbKesehatans { get; set; }
        public virtual DbSet<TbMotivasi> TbMotivasis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
