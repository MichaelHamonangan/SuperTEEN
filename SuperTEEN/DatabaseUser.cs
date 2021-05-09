using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SuperTEEN
{
    public partial class DatabaseUser : DbContext
    {
        public DatabaseUser()
            : base("name=DatabaseUser")
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
