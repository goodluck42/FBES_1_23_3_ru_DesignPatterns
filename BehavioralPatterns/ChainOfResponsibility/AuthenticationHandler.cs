namespace BehavioralPatterns.ChainOfResponsibility;

public class AuthenticationHandler(UserDbContext dbContext) : BaseHandler<UserData>
{
    public override void Handle(UserData data)
    {
        var result = dbContext.Users.FirstOrDefault(u => u.Login == data.Dto.Login);

        if (result is null)
        {
            throw new AuthenticationHandlerException();
        }

        if (result.Password != data.Dto.Password)
        {
            throw new AuthenticationHandlerException();
        }

        data.DbUser = result;

        Next?.Handle(data);
    }
}