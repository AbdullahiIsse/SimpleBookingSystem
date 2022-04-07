using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleBookingSystemApi.Model;

namespace SimpleBookingSystemApi.Data
{
    public interface IResourceData
    {
        Task<List<Resource>> GetResources();
    }
}