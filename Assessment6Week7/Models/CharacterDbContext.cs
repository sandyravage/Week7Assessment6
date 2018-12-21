namespace Assessment6Week7.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CharacterDbContext : DbContext
    {
        public CharacterDbContext()
            : base("name=Character")
        {
        }

        public virtual DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
