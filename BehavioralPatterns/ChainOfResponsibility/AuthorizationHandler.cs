namespace BehavioralPatterns.ChainOfResponsibility;

public class AuthorizationHandler(UserDbContext dbContext) : BaseHandler<UserData>
{
    public override void Handle(UserData data)
    {
        if (data.DbUser is null)
        {
            throw new NullReferenceException($"{nameof(data.DbUser)} is null.");
        }
        
        if (data.DbUser!.Rights.Contains(dbContext.Rights.Last()))
        {
            throw new AuthorizationHandlerException();
        }

        Next?.Handle(data);
    }
}