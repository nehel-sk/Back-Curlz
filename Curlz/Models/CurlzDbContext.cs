using Microsoft.EntityFrameworkCore;
namespace Curlz.Models
{
    public class CurlzDbContext:DbContext
    {
        public CurlzDbContext(DbContextOptions<CurlzDbContext> options) : base(options)
        { }

        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<Slot> Slots { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>()
                .Property(x => x.Role)
                .HasDefaultValue("User");
        }
    }
}
