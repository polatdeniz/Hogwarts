using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dnzHogwards;

namespace HogwartsWeb.Data
{
    public class HogwartsWebContext : DbContext
    {
        public HogwartsWebContext (DbContextOptions<HogwartsWebContext> options)
            : base(options)
        {
        }

        public DbSet<dnzHogwards.Course> Course { get; set; } = default!;
        public DbSet<dnzHogwards.Enrollment> Enrollment { get; set; } = default!;
        public DbSet<dnzHogwards.House> House { get; set; } = default!;
        public DbSet<dnzHogwards.Pet> Pet { get; set; } = default!;
        public DbSet<dnzHogwards.Professor> Professor { get; set; } = default!;
        public DbSet<dnzHogwards.Spell> Spell { get; set; } = default!;
        public DbSet<dnzHogwards.Student> Student { get; set; } = default!;
        public DbSet<dnzHogwards.Wand> Wand { get; set; } = default!;
        public DbSet<dnzHogwards.WandMaintenanceAlert> WandMaintenanceAlert { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Wand>()
                        .ToTable(tb => tb.HasTrigger("Trigger_Wand_Update"));
        }
    }
}
