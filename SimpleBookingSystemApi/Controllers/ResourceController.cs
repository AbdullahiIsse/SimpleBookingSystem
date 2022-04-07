using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleBookingSystemApi.Data;
using SimpleBookingSystemApi.Model;

namespace SimpleBookingSystemApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResourceController : ControllerBase
    {

        private IResourceData _resourceData;

        public ResourceController(IResourceData resourceData)
        {
            _resourceData = resourceData;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Resource>>> GetResources()
        {
            try
            {
                var resources = await _resourceData.GetResources();

                return Ok(resources);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
            
            
        }
        
    }
    
}
    
    