using BehavioralPatterns.Iterator;
using System.Collections;
using BehavioralPatterns.ChainOfResponsibility;
using BehavioralPatterns.Observer;

//
// var fixedArray = new FixedObservableArray<int>(6);
//
// fixedArray.CollectionChanged += (sender, args) =>
// {
//     if (args.NewItems is null)
//     {
//         return;
//     }
//
//     foreach (var item in args.NewItems)
//     {
//         Console.WriteLine($"Item added: {item}");
//     }
// };
//
// fixedArray.Add(10);
// fixedArray.Add(20);
// fixedArray.Add(30);
// fixedArray.Add(40);
// fixedArray.Add(50);
// fixedArray.Add(60);


// foreach (var value in fixedArray)
// {
//     
// }

// using var enumerator = fixedArray.GetEnumerator();
// // _currentIndex = 0
// while (enumerator.MoveNext())
// {
//     Console.WriteLine(enumerator.Current);
// }
//
// enumerator.Reset();

var dbContext = new UserDbContext();
var application = new App();
var authenticationHandler = new AuthenticationHandler(dbContext);
var authorizationHandler = new AuthorizationHandler(dbContext);
var personalDataValidatorHandler = new PersonalDataValidatorHandler(application);

authenticationHandler.Next = authorizationHandler;
authorizationHandler.Next = personalDataValidatorHandler;


authenticationHandler.Handle(new UserData
{
    Dto = new()
    {
        Login = "login",
        Password = "qwerty1",
    }
});

