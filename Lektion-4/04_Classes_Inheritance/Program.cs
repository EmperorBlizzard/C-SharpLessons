using _04_Classes_Inheritance.Models;
using _04_Classes_Inheritance.Services;

//var privateCustomer = new PrivateCustomer()
//{
//    Id = Guid.NewGuid(),
//    Created = DateTime.Now,
//    Modified = DateTime.Now,
//    Email = "emil111@live.se",


//    FirstName = "Emil",
//    LastName = "Olsson",
//    PhoneNummber = "12345"
//};

//var companyCustomer  = new CompanyCustomer() 
//{
//    Id = Guid.NewGuid(),
//    Created = DateTime.Now,
//    Modified = DateTime.Now,
//    Email = "emil111@live.se",

//    CompanyName = "",
//    PhoneNummber = "12345"
//};

Console.Write("Vad för kund vill du skapa (p för privatkund, f för företagskund)");
var option = Console.ReadLine();

switch (option!.ToLower())
{
    case "p":
        CustomerService.CreatePrivateCustomer();
        break;

    case "f":
        CustomerService.CreateCompanyCustomer();
        break;

    default:
        break;
}