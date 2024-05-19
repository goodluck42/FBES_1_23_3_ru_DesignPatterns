namespace BehavioralPatterns.ChainOfResponsibility;

public class PersonalDataValidatorHandler(App app) : BaseHandler<UserData>
{
    public override void Handle(UserData data)
    {
        var diff = DateTime.Now - data.DbUser!.BirthDate;

        if (diff.Days < 365 * 18)
        {
            throw new PersonalDataValidatorHandlerException();
        }

        app.Run(data.Dto);
    }
}