using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RequestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class XmlValuesController : ControllerBase
    {
        [EnableCors]
        [HttpGet]
        
        public IEnumerable <string> Get()
        {
            return new string[] { "values 1", "values 2" }; 
        }
    }
}
