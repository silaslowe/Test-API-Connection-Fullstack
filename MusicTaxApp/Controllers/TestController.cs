using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using MusicTaxApp.Models;
using MusicTaxApp.Repositories;

namespace MusicTaxApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly ITestRepository _testRepository;

        public TestsController(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Test>> GetTests()
        {
            return await _testRepository.Get();
        }

        [HttpPost]
        public async Task<ActionResult<Test>> PostTests([FromBody] Test test)
        {
            var newTest = await _testRepository.Create(test);
            return CreatedAtAction(nameof(GetTests),  newTest);
        }
    }
}

