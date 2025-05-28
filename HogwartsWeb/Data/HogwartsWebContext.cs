using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AbdHogwarts;

namespace HogwartsWeb.Data
{
    public class HogwartsWebContext : DbContext
    {
        public HogwartsWebContext (DbContextOptions<HogwartsWebContext> options)
            : base(options)
        {
        }

        public DbSet<AbdHogwarts.Course> Course { get; set; } = default!;
        public DbSet<AbdHogwarts.Enrollment> Enrollment { get; set; } = default!;
        public DbSet<AbdHogwarts.House> House { get; set; } = default!;
        public DbSet<AbdHogwarts.Pet> Pet { get; set; } = default!;
        public DbSet<AbdHogwarts.Professor> Professor { get; set; } = default!;
        public DbSet<AbdHogwarts.Spell> Spell { get; set; } = default!;
        public DbSet<AbdHogwarts.Student> Student { get; set; } = default!;
        public DbSet<AbdHogwarts.Wand> Wand { get; set; } = default!;
        public DbSet<AbdHogwarts.WandMaintenanceAlert> WandMaintenanceAlert { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Wand>()
                        .ToTable(tb => tb.HasTrigger("Trigger_Wand_Update"));
        }
    }
}
