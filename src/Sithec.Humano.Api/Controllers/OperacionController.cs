using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sithec.Humano.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OperacionController : ControllerBase
    {
        [Route("suma")]
        [HttpPost]
        public int suma(int x, int y, int z)
        {
            return x + y + z;
        }

        [Route("multi")]
        [HttpPost]
        public int multi(int x, int y, int z)
        {
            return x * y * z;
        }

        [Route("sumah")]
        [HttpGet]
        public int sumah([FromHeader]int x, [FromHeader] int y, [FromHeader] int z)
        {   
            return x + y + z;
        }

    }
}
