using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CustomAuthorizeFilterAspNetCore20.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        // GET api/values/single
        [AllowAnonymous]
        [HttpGet]
        [Route("single")]
        public string GetSingle()
        {
            return "value";
        }
    }
}
