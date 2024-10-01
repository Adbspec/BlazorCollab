using BlazorCollab.Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCollab.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {

        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "TestMethod")]
        public IEnumerable<TestClass> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new TestClass
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
              
            })
            .ToArray();
        }
    }
}
