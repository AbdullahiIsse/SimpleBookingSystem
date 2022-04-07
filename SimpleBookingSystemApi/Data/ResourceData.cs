using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleBookingSystemApi.DataAccess;
using SimpleBookingSystemApi.Model;

namespace SimpleBookingSystemApi.Data
{
    public class ResourceData: IResourceData
    {
        
        private BookingContext bookingContext;

        public ResourceData(BookingContext bookingContext)
        {
            this.bookingContext = bookingContext;
        }
        
        
        public async Task<List<Resource>> GetResources()
        {
            var resourceList = await bookingContext.Resources.Include(resource => resource.Bookings ).ToListAsync();
            return resourceList;
            
        }
    }
}