using DependencyInjection.Service;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Implementation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoSomethingController : ControllerBase
    {
        private readonly IDoSomethingService _doSomethingService;
        public DoSomethingController(IDoSomethingService doSomethingService)
        {
            _doSomethingService = doSomethingService;          
        }

        [HttpGet]
        public string DoSomething(string thing)
        {
            return _doSomethingService.DoSomething(thing);
        }

    }
}
