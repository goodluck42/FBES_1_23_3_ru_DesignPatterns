namespace BehavioralPatterns.ChainOfResponsibility;

public record UserDto
{
    public string? Login { get; set; }
    public string? Password { get; set; }
    public DateTime? BirthDate { get; set; }
}