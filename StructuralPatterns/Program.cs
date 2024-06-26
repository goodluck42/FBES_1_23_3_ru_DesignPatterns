﻿// using StructuralPatterns.Adapter;
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


// using StructuralPatterns.Decorator;
//
// var accountManager = new AccountManager();
// var fileDecorator = new FileAccountDecorator(accountManager);
// var consoleDecorator = new ConsoleAccountInfoDecorator(fileDecorator);
//
// consoleDecorator.Add(new Account()
// {
//     Id = 42
// });

using System.Diagnostics;
using StructuralPatterns.Composite;
using StructuralPatterns.Facade;
using StructuralPatterns.Proxy;

//
// //
// var imageLoader = new HttpImageLoader();
// var imageApi = new ImageApi(imageLoader);
//
// imageApi.OpenImage();

// Process.Start("mspaint", new[] { fileFound });
// var imageLoader = new HttpImageLoader();
// var imageApi = new ImageApi(imageLoader, filePath => { Process.Start("mspaint", new[] { filePath }); });
// var imageProxy = new ImageApiProxy(imageApi);
//
// imageProxy.OpenImage(@"https://as1.ftcdn.net/v2/jpg/04/97/69/24/1000_F_497692451_3Sl6vbIXVtS7metinrh8FrH10zf7543z.jpg");
// imageProxy.OpenImage(@"https://upload.wikimedia.org/wikipedia/en/thumb/f/f3/Flag_of_Russia.svg/1200px-Flag_of_Russia.svg.png");


var facade = new ControlFacade();

Console.WriteLine(facade.RenderCustomControl());
Console.WriteLine(facade.RenderSuperButton("ButtonName"));
Console.WriteLine(facade.RenderSuperButton("ButtonName2"));
Console.WriteLine(facade.RenderSuperButton("ButtonName3"));

// var listBox = new ListBox();
// var button = new Button();
// var button2 = new Button();
// var textBlock = new TextBlock();
//
// listBox.AddChild(button);
// button.AddChild(textBlock);
// button.AddChild(button2);

//Console.WriteLine(listBox.Render());


partial class Program
{
    public void Init(ControlFacade facade)
    {
        
    }
}