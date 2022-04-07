using System.Threading.Tasks;
using SimpleBookingSystemApi.Model;

namespace SimpleBookingSystemApi.Data
{
    public interface IBookingData
    {
        Task<Booking> AddBooking(Booking booking,int id);

        Task<bool> ValidateQuantity(Booking booking, int id);

        Task<bool> ValidateDates(Booking booking, int id);
    }
}