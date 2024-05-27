using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MyMotivationBlazorApp.Model;

namespace MyMotivationBlazorApp.Context
{
    public class DatabaseContext : IdentityDbContext<User>
    {
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Philosopher> Philosophers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbpath = @"C:\Users\khank\Documents\GitHub\MyMotivationBlazorApp\mymotivation.db";
            optionsBuilder.UseSqlite($"Data Source={dbpath}");
        }

    }
}
