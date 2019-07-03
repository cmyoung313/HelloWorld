using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.BLL;

namespace HelloWorld.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        public IHelloWorldRepository _helloWorldRepository;

        public ValuesController(IHelloWorldRepository iHelloWorldRepository)
        {
            _helloWorldRepository = iHelloWorldRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _helloWorldRepository.Write();

            return new string[] { "value1", "value2" };
        }
    }
}
