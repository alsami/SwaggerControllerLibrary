using Microsoft.AspNetCore.Mvc;

namespace SwaggerControllerLibrary.Controllers
{
    [ApiController]
    [Route("api/v1/sample")]
    public class SampleController : Controller
    {
        [HttpGet]
        public SampleModel Get() => new SampleModel()
        {
            A = "B"
        };
    }
}