namespace BehavioralPatterns.ChainOfResponsibility;

public record User
{
    public User()
    {
        Rights = ["guest"];
    }

    public string? Login { get; set; }
    public string? Password { get; set; }
    public DateTime BirthDate { get; set; }
    public Guid SecurityToken { get; set; }

    public IEnumerable<string> Rights { get; set; }

    public UserDto ToDto()
    {
        return new UserDto
        {
            Login = this.Login,
            BirthDate = this.BirthDate
        };
    }
}