using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleBookingSystemApi.Data;
using SimpleBookingSystemApi.Model;

namespace SimpleBookingSystemApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController : ControllerBase
    {

        private IBookingData bookingData;


        public BookingController(IBookingData bookingData)
        {
            this.bookingData = bookingData;
        }
        
        

        [HttpPost("{id}")]
        public async Task<ActionResult<Booking>> Book([FromBody] Booking booking, [FromRoute] int id)
        {
            try
            {
              
                var bookingAdded = await bookingData.AddBooking(booking, id);
            
                return Created($"/{bookingAdded.Id}", bookingAdded);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(booking.Id);
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }


        }

    }
}