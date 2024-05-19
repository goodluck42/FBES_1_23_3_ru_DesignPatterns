namespace BehavioralPatterns.ChainOfResponsibility;

public class UserData
{
    public User? DbUser { get; set; }
    public required UserDto Dto { get; set; }
}