using Homework.dto;
using Microsoft.AspNetCore.Mvc;
using System.Text;

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
        public string TransformNumber([FromBody] NumberDto numberDto)
        {
            string numbers = numberDto.number.ToString();
            StringBuilder numberInWord = new StringBuilder();

            foreach (char n in numbers)
            {
                switch (n)
                {
                    case '0': numberInWord.Append("ZERO, "); break;
                    case '1': numberInWord.Append("ONE, "); break;
                    case '2': numberInWord.Append("TWO, "); break;
                    case '3': numberInWord.Append("THREE, "); break;
                    case '4': numberInWord.Append("FOUR, "); break;
                    case '5': numberInWord.Append("FIVE, "); break;
                    case '6': numberInWord.Append("SIX, "); break;
                    case '7': numberInWord.Append("SEVEN, "); break;
                    case '8': numberInWord.Append("EIGHT, "); break;
                    case '9': numberInWord.Append("NINE, "); break;
                }
            }

            return numberInWord.ToString().Trim();
        }


    }
}
