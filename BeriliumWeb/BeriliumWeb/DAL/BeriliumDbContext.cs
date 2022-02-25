using BeriliumWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BeriliumWeb.DAL
{
    public class BeriliumWebDbContext : DbContext
    {
        public BeriliumWebDbContext(DbContextOptions<BeriliumWebDbContext> options) : base(options) 
        { }

        public DbSet<Banner> Banners { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
        public DbSet<Features> Features { get; set; }
    }
}
    
     

