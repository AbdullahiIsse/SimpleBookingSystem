using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SimpleBookingSystemBlazor.Model;

namespace SimpleBookingSystemBlazor.Data
{
    public class BookingData: IBookingData
    {
        
        public async Task<Booking> Book(Booking booking, int id)
        {
            using HttpClient client = new HttpClient();

            var bookingSerialize = JsonSerializer.Serialize(booking);

            HttpContent httpContent = new StringContent(
                bookingSerialize, Encoding.UTF8, "application/json");

            var httpResponseMessage = await client.PostAsync($"https://localhost:5001/Booking/{id}", httpContent);

            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                throw new Exception("The Resource or Quantity is not available for the requested dates");
            }

            return booking;
        }
    }
}