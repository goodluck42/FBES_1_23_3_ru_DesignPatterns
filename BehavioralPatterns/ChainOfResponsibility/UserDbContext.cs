namespace BehavioralPatterns.ChainOfResponsibility;

public class UserDbContext
{
    public UserDbContext()
    {
        Users =
        [
            new()
            {
                Login = "log1",
                Password = "pass2",
                BirthDate = DateTime.Now,
                SecurityToken = Guid.NewGuid()
            },
            new()
            {
                Login = "login",
                Password = "qwerty1",
                BirthDate = DateTime.Now,
                SecurityToken = Guid.NewGuid(),
                Rights = ["guest"]
            }
        ];

        Rights =
        [
            "guest",
            "user",
            "admin",
            "mod",
            "banned"
        ];
    }

    public List<User> Users { get; }
    public List<string> Rights { get; }
}