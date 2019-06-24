using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace service2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EthicsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "ethic1", "ethic2" };
        }
    }
}
