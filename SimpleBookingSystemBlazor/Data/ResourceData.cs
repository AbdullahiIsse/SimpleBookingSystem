using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using SimpleBookingSystemBlazor.Model;

namespace SimpleBookingSystemBlazor.Data
{
    public class ResourceData: IResourceData
    {
        
        public async Task<IList<Resource>> GetResources()
        {
            using HttpClient client = new HttpClient();

            var httpResponseMessage = await client.GetAsync("https://localhost:5001/Resource");
            
            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                throw new Exception("failed to fetch data");
            }
            

            var readAsStringAsync = await httpResponseMessage.Content.ReadAsStringAsync();

            IList<Resource> resources = JsonSerializer.Deserialize<IList<Resource>>(readAsStringAsync, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });


            return resources;
        }
    }
}