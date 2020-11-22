namespace DIP.Final.Models
{
    public record Dog(int Age, string Name, string Trick) : Pet(Age, Name);
}