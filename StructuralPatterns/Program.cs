// using StructuralPatterns.Adapter;
//
// var userTxtStorage = new UserTxtStorage("users.txt");
// var adapter = new UserStorageAdapter(userTxtStorage);
//
// adapter.WriteUser(new User
// {
//     Id = 1,
//     Login = "MyLogin",
//     Password = "MyPassword"
// });
//
// adapter.WriteUser(new User
// {
//     Id = 2,
//     Login = "MyLogin2",
//     Password = "MyPassword2"
// });
//
// IEnumerable<User> users = adapter.ReadAllUsers();
//
// var result = users.FirstOrDefault(u => u.Id == 1);
//
// if (result != null)
// {
//     Console.WriteLine(result.Id);
//     Console.WriteLine(result.Login);
//     Console.WriteLine(result.Password);
// }


using StructuralPatterns.Decorator;

var accountManager = new AccountManager();
var fileDecorator = new FileAccountDecorator(accountManager);
var consoleDecorator = new ConsoleAccountInfoDecorator(fileDecorator);

consoleDecorator.Add(new Account()
{
    Id = 42
});