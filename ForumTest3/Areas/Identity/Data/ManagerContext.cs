using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ForumTest3.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ForumTest3.Areas.Identity.Data
{
    public class ManagerContext : IdentityDbContext<ApplicationUsers>
    {
        public ManagerContext(DbContextOptions<ManagerContext> options)
            : base(options)
        {
        }

        public DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Topic>()
                .HasOne(u => u.User)
                .WithMany(c => c.Topics)
                .HasForeignKey(u => u.Creator);

        }
    }
}
