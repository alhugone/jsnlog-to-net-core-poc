using System;
using Microsoft.AspNetCore.Mvc;

namespace JSNLogPoc.Controllers
{
    [Route("api/[controller]")]
    public class GuidController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
