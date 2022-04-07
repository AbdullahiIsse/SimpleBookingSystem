using System.Collections.Generic;

namespace SimpleBookingSystemBlazor.Model
{
    public class Resource
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }


        public IList<Booking> Bookings { get; set; }
    }
}