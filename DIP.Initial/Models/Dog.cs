using System.ComponentModel.DataAnnotations;

namespace DIP.Initial.Models
{
    public record Dog([Range(0, 30)] int Age, [Required] string Name, [MinLength(2)] string Trick) : Pet(Age, Name);
}