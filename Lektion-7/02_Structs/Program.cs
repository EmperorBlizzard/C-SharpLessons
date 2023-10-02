using _02_Structs.Structs.Domain_Driven_Design;
using _02_Structs.Structs.Interoperability;
using _02_Structs.Structs.Mathematical_Models;
using _02_Structs.Structs.Performance_Sensitive;
using _02_Structs.Structs.Value_Semantics;

// Matematiska Modeller
Vector2D vector = new Vector2D(3.0, 4.0);
Console.WriteLine($"Vector: x={vector.X}, y={vector.Y}");
Console.ReadKey();

// Interoperability
Todo todo = new Todo 
{
    userId = 1, id = 1, title="delectus aut autem", completed=false
};
Console.WriteLine($"Todo: {todo.id} - {todo.title}");
Console.ReadKey();

// Prestanda-känsliga Applikationer
RgbColor color = new RgbColor(255, 0, 0);
Console.WriteLine($"Color: R={color.R}, G={color.G}, B={color.B}");
Console.ReadKey();

// Värdesemantik
Money salary = new Money(500M, "SEK");
Console.WriteLine($"Money: Amount={salary.Amount} Currency={salary.Currency}");
Console.ReadKey();

// Domain Driven Design (DDD)
User user = new User 
{
    FirstName = "Emil",
    LastName = "Olsson",
    Email = new Email("emil111@live.se"),
    Password = new Password("12345ABcd!?"),
};

Console.WriteLine($"{user.FirstName} {user.LastName} <{user.Email}>");
Console.ReadKey();