using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PRS_Server.Models;

namespace PRS_Server.Data
{
    public class PRS_ServerContext : DbContext
    {
        public PRS_ServerContext (DbContextOptions<PRS_ServerContext> options)
            : base(options)
        {
        }

        public DbSet<PRS_Server.Models.User> Users { get; set; }
        public DbSet<PRS_Server.Models.Vendor> Vendors { get; set; }
        public DbSet<PRS_Server.Models.Product> Products { get; set; }
        public DbSet<PRS_Server.Models.Request> Requests { get; set; }
        public DbSet<PRS_Server.Models.RequestLine> RequestLines { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        { builder.Entity<User>(u => 
            {//making user.username unique
            u.HasIndex(p => p.Username).IsUnique();
            });
            //making vendor.code unique
            builder.Entity<Vendor>(v =>
            {
                v.HasIndex(p => p.Code).IsUnique();
            });
            //making product.PartNbr unique
            builder.Entity<Product>(p =>
            {
                p.HasIndex(x => x.PartNbr).IsUnique();
            });
        }
    }
}
