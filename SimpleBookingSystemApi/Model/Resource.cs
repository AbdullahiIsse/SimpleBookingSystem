using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleBookingSystemApi.Model
{
    public class Resource
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public IList<Booking> Bookings { get; set; }
    }
}