using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JournalApi.Articles;
using Microsoft.EntityFrameworkCore;

namespace JournalApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-QF1AB38\\SQLEXPRESS; Database= Articles; TrustServerCertificate=True; Trusted_Connection=True"
            );
            base.OnConfiguring(optionsBuilder);
        }
    }
}
