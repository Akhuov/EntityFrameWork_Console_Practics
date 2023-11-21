using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NTT_FrameWork.Enums;

namespace NTT_FrameWork.DataBase
{
    internal class UserDB : DbContext
    {
        private readonly string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=56767655;Database=UserDB";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(p => p.Gender)
                .HasDefaultValue(Gender.Male)
                .HasConversion<string>();
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
    }
}
