using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VisitorManagementSystem.Models;

namespace VisitorManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
            modelbuilder.Entity<Visitor>()
           .HasOne(v => v.Manager) //one visitor has one manager
           .WithMany(m => m.Visitors) // one manager has many visitor
           .HasForeignKey(v => v.ManagerId); //foreign key as managerId
        }
        
    }
}
