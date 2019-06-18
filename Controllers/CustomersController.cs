using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace jwtTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        //Miren como el API esta proegido por el Authorize.
        [HttpGet, Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] {"John Doe, Jane Doe"};
        }
    }
}