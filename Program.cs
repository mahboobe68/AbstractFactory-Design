// See https://aka.ms/new-console-template for more information
using AbstractFactory;

Console.WriteLine("Hello, World!");

IMobilePhone mobileNokia = new Nokia();
MobileClient mobileClientNokia = new MobileClient(mobileNokia);

Console.WriteLine(mobileClientNokia.GetNormalMobilePhone());
Console.WriteLine(mobileClientNokia.GetSmartMobilePhone());


IMobilePhone mobileSumsong = new Samsung();
MobileClient mobileClientSumsong = new MobileClient(mobileSumsong);
Console.WriteLine(mobileClientSumsong.GetNormalMobilePhone());
Console.WriteLine(mobileClientSumsong.GetNormalMobilePhone());

