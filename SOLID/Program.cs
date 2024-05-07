#region Aggregation

// var logger = new Logger();
// var service = new Service(logger);
//
// service.FetchData();
//
// class Service
// {
//     private Logger _logger;
//     
//     public Service(Logger logger)
//     {
//         _logger = logger;
//     }
//     public object FetchData()
//     {
//         _logger.LogInfo("FetchData");
//         
//         return new object();
//     }
// }
//
// class Logger
// {
//     public void LogInfo(string message)
//     {
//         Console.WriteLine(message);
//     }
// }
#endregion

#region Composition

// using System.Text;
//
// {
//     var service = new Service();
// }
//
// class Service
// {
//     public StringBuilder Builder { get; set; }
//     
//     public Service()
//     {
//         Builder = new StringBuilder();
//     }
//     
//     public string FetchData()
//     {
//         Builder.Append(nameof(Service));
//
//         return Builder.ToString();
//     }
// }

#endregion

#region Dependency
//
//
// class Program
// {
//     private static Logger _logger;
//     static void Main(string[] args)
//     {
//         _logger = new Logger();
//         var service = new UserManager(_logger);
//     }
// }
//
// class UserManager
// {
//     private readonly Logger _logger;
//     
//     public UserManager(Logger logger)
//     {
//         _logger = logger;
//     }
//     
//     public object FetchData()
//     {
//         _logger.LogInfo("FetchData");
//         
//         return new object();
//     }
// }
//
// class Logger
// {
//     public void LogInfo(string message)
//     {
//         Console.WriteLine(message);
//     }
// }
#endregion


// User u = new SuperUser();
//
// // Liskov violation!
// if (u is SigmaUser su)
// {
//     su.DoSigma();
// }

// SOLID

using System.Diagnostics;

class User
{
    public int Id { get; set; }
    public string? Login { get; set; }
    public string? Password { get; set; }

    public virtual void Show()
    {
        Console.WriteLine(this);
    }
}

class SuperUser : User {}

// S - Single Responsibility

#region SingleResponsibility


//
// class Item;
//
// abstract class UserManager
// {
//     public abstract void AddUser(User user);
//     public abstract void RemoveUser(int id);
//     public abstract void AddItem(Item item); // violation!
//     public abstract bool ValidateUser(User user); // violation!
// }
#endregion

// O - Open close principle
#region OpenClosePrinciple
class UserManager
{
    public List<User> _users = new(); // Violation!!!

    public void AddUser(User person)
    {
    }

    public void RemoveUser(User person)
    {
    }
}
#endregion


// L - Barbara Liskov

#region BarbaraLiskov

// class SuperUser : User
// {
//     public override void Show()
//     {
//         Console.WriteLine($"{this} {nameof(SuperUser)}");
//     }
// }
//
// class SigmaUser : User
// {
//     public override void Show()
//     {
//         Console.WriteLine($"{this} {nameof(SigmaUser)}");
//     }
//
//     public void DoSigma() // violation!
//     {
//         Console.WriteLine("Doing Sigma!");
//     }
// }
#endregion


// I - Interface Segregation

#region InterfaceSegregation
//
interface IPaymentSystem
{
    void PayCash(int amount); // violation!
    void PayCreditCard(int amount); // violation!
}
//
// // Workaround
// interface IPayment
// {
//     void Pay(int amount);
// }
//
// interface ICashPayment : IPayment
// {
//     void PayCash(int amount);
// }
//
// interface ICardPayment : IPayment
// {
//     void PayCard(int amount);
// }
//
// // Workaround END
//
// class PaymentSystem : IPaymentSystem
// {
//     public void PayCash(int amount)
//     {
//         throw new NotSupportedException("Paying cash is not supported!");
//     }
//
//     public void PayCreditCard(int amount)
//     {
//         throw new NotImplementedException();
//     }
// }

#endregion

// D - Dependency Inversion

interface IUserManager
{
    void AddUser(SuperUser user); // violation!
    void AddUser(User user); // ok!
    void RemoveUser(int id);
    IEnumerable<User> GetAll();
}

interface IUserManager2
{
    IEnumerable<User> GetAll();
}

class UserManager1 : IUserManager2
{
    public IEnumerable<User> GetAll()
    {
        return new List<User>();
    }
}

class UserManager2 : IUserManager2
{
    public IEnumerable<User> GetAll()
    {
        return new HashSet<User>();
    }
}



