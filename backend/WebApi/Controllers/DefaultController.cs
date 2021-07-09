using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("")]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hallo David v1 - Run on OpenShift ;)";
        }
    }
}
