using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleBookingSystemApi.DataAccess;
using SimpleBookingSystemApi.Model;

namespace SimpleBookingSystemApi.Data
{
    public class BookingData: IBookingData
    {
        private BookingContext bookingContext;
        

        public BookingData(BookingContext bookingContext)
        {
            this.bookingContext = bookingContext;
        }
        
        
        
        
        public async Task<Booking> AddBooking(Booking booking, int id)
        {
            var resources = await bookingContext.Resources.Include(resource => resource.Bookings)
                .Where(resource => resource.Id == id)
                .FirstOrDefaultAsync();


            if (await ValidateDates(booking, id))
            {
                throw new Exception("The resource is already booked");
            }

            if (await ValidateQuantity(booking, id))
            {
                var bookingAdded = await bookingContext.Bookings.AddAsync(booking);
                Booking bookingAddedEntity = bookingAdded.Entity;
                bookingAddedEntity.Resource = resources;
                await bookingContext.SaveChangesAsync();

                return booking;
            }

            throw new Exception("The resource quantity is not available");
        }

        
        
        
        public async Task<bool> ValidateQuantity(Booking booking, int id)
        {
            var resources = await bookingContext.Resources
                .Where(resource => resource.Id == id).FirstOrDefaultAsync();

            if (resources != null && resources.Quantity >= booking.BookedQuantity)
            {
                
                return true;
            }

            return false;
        }

        
        
        
        public async Task<bool> ValidateDates(Booking booking, int id)
        {
            var resources = await bookingContext.Resources.Include(resource => resource.Bookings)
                .Where(resource => resource.Id == id)
                .FirstOrDefaultAsync();


            var existingBooking = resources.Bookings
                .FirstOrDefault(booking1 => booking1.Resource.Id == id
                                            && (booking.DateFrom <= booking1.DateTo &&
                                                booking.DateFrom >= booking1.DateFrom ||
                                                booking.DateTo > booking1.DateFrom &&
                                                booking.DateFrom <= booking1.DateFrom));
            if (existingBooking != null)
            {
                return true;
            }

            return false;
        }
    }
}