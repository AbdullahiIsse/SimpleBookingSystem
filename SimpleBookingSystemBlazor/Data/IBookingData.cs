using System.Threading.Tasks;
using SimpleBookingSystemBlazor.Model;

namespace SimpleBookingSystemBlazor.Data
{
    public interface IBookingData
    {
        Task<Booking> Book(Booking booking, int id);
    }
}