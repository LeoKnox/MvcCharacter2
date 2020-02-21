using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcCharacter.Models;

namespace MvcCharacter.Data
{
    public class MvcCharacterContext : DbContext
    {
        public MvcCharacterContext (DbContextOptions<MvcCharacterContext> options)
            : base(options)
        {
        }

        public DbSet<Character> Character { get; set; }
        public DbSet<SpellBook> SpellBooks { get; set; }
        public DbSet<Spell> Spells { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Spell>().ToTable("Spell");
            modelBuilder.Entity<SpellBook>().ToTable("SpellBook");
            modelBuilder.Entity<Character>().ToTable("Character");
        }
    }
}
