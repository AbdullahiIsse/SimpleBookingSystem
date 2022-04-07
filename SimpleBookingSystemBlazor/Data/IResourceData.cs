using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleBookingSystemBlazor.Model;

namespace SimpleBookingSystemBlazor.Data
{
    public interface IResourceData
    {
        Task<IList<Resource>> GetResources();
    }
}