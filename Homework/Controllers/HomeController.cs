using Homework.dto;
using Microsoft.AspNetCore.Mvc;

namespace Homework.Controllers
{

    [ApiController]
    [Route("/api/v1/homework")]
    public class HomeController : Controller
    {
        [HttpGet("current-time")]
        public DateTime GetCurrentTime()
        {
            return DateTime.Now;
        }

        [HttpGet("current-age")]
        public int GetCurrentAge()
        {

            DateTime dob = new DateTime(2002, 02, 14);
            return DateTime.Now.Year - dob.Year;
        }

        [HttpGet("random-number")]
        public int GetRandomNumber()
        {
            return new Random().Next();
        }

        [HttpPost("transform-number")]
        public int TransfomNumber([FromBody] NumberDto numberDto)
        {
            return numberDto.number;
        }

    }
}
