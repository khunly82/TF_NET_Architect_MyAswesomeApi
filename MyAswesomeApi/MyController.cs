using Microsoft.AspNetCore.Mvc;

namespace MyAswesomeApi
{
    [ApiController]
    public class MyController: ControllerBase
    {

        [HttpGet("api/hello")]
        public string Hello(string nom = "world")
        {
            return $"Hello {nom} !!";
        }
    }
}
