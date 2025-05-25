using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hogwarts;

namespace HogwartsWeb.Data
{
    public class HogwartsWebContext : DbContext
    {
        public HogwartsWebContext (DbContextOptions<HogwartsWebContext> options)
            : base(options)
        {
        }

        public DbSet<Hogwarts.Course> Course { get; set; } = default!;
        public DbSet<Hogwarts.Enrollment> Enrollment { get; set; } = default!;
        public DbSet<Hogwarts.House> House { get; set; } = default!;
        public DbSet<Hogwarts.Pet> Pet { get; set; } = default!;
        public DbSet<Hogwarts.Professor> Professor { get; set; } = default!;
        public DbSet<Hogwarts.Spell> Spell { get; set; } = default!;
        public DbSet<Hogwarts.Student> Student { get; set; } = default!;
        public DbSet<Hogwarts.Wand> Wand { get; set; } = default!;
        public DbSet<Hogwarts.WandMaintenanceAlert> WandMaintenanceAlert { get; set; } = default!;
    }
}
