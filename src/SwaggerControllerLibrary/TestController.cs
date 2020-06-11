using Microsoft.AspNetCore.Mvc;

namespace SwaggerControllerLibrary
{
    [ApiController]
    [Route("api/v1/test")]
    public class Test : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return this.Ok(new
            {
                Message = "HelloWorld"
            });
        }
    }
}