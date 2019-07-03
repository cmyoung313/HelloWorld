using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.BLL;

namespace HelloWorld.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : Controller
    {
        public IHelloWorldRepository _helloWorldRepository;

        public HelloController(IHelloWorldRepository iHelloWorldRepository)
        {
            _helloWorldRepository = iHelloWorldRepository;
        }

        // GET api/values
        [HttpGet("Write", Name = "Write")]
        public ActionResult<IEnumerable<string>> Write()
        {
            string retVal = _helloWorldRepository.Write();

            return Ok(retVal);
        }
    }
}