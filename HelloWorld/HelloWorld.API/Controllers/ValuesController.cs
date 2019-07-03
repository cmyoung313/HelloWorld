using System.Collections.Generic;
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
        [HttpGet("Write", Name = "Write")]
        public ActionResult<IEnumerable<string>> Write()
        {
            _helloWorldRepository.Write();

            return Ok();
        }
    }
}