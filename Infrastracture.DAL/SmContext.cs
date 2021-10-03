using Domain.Entittes;
using Infrastracture.DAL.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastracture.DAL
{
    public class SmContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=DbSample8;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TblUserConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<TblUser> TblUsers { get; set; }
    }
}
