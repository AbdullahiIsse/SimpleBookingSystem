using Microsoft.EntityFrameworkCore;
using SimpleBookingSystemApi.Model;

namespace SimpleBookingSystemApi.DataAccess
{
    public class BookingContext: DbContext
    {
        
        public DbSet<Resource> Resources { get; set; }

        public DbSet<Booking> Bookings { get; set; }
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Booking.db");
        }
        
    }
}