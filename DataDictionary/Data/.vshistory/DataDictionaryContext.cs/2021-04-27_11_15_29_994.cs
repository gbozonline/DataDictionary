using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataDictionary.Models;

namespace DataDictionary.Data
{
    public class DataDictionaryContext : DbContext
    {
        public DataDictionaryContext(DbContextOptions<DataDictionaryContext> options)
            : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<KeywordDefinition> KeywordDefinitions { get; set; }
        public DbSet<Keyword> Keywords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KeywordDefinition>()
                .HasOne(d => d.Application)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Keyword>()
                .HasOne(d => d.KeywordDefinition)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
