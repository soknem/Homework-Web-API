using System.ComponentModel.DataAnnotations;

namespace Homework.dto
{
    public record NumberDto
    {
        [Range(0, int.MaxValue, ErrorMessage = "Id must be positive or zero.")]
        public int number { get; init; }
    }
}
