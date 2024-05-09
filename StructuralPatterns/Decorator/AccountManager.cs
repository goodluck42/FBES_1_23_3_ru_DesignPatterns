namespace StructuralPatterns.Decorator;

public class Account
{
    public int Id { get; set; }
}

public interface IAccountManager
{
    void Add(Account account);
}

public class AccountManager : IAccountManager
{
    private List<Account> _accounts;

    public AccountManager()
    {
        _accounts = new List<Account>();
    }
    
    public virtual void Add(Account account)
    {
        _accounts.Add(account);
    }
}

public abstract class BaseDecorator : AccountManager
{
    protected IAccountManager AccountManager;
    
    protected BaseDecorator(IAccountManager accountManager)
    {
        AccountManager = accountManager;
    }
}

public class ConsoleAccountInfoDecorator : BaseDecorator
{
    public ConsoleAccountInfoDecorator(IAccountManager accountManager) : base(accountManager)
    {
        
    }

    public override void Add(Account account)
    {
        AccountManager.Add(account);

        Console.WriteLine($"{account.Id}");
    }
}

public class FileAccountDecorator : BaseDecorator
{
    public FileAccountDecorator(IAccountManager accountManager) : base(accountManager)
    {
        
    }

    public override void Add(Account account)
    {
        AccountManager.Add(account);
        
        Console.WriteLine("Account added to file");
    }
}