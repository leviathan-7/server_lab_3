using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class WebContext: DbContext
    {
        public WebContext(DbContextOptions<WebContext> options) : base(options)
        {}
        public DbSet<Testimonial> Testimonials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Testimonial>().ToTable("testimonials");
        }
    }
}
