using _03_Records.Records;

var user = new User("Emil", "Olsson", "emil111@live.se");

Console.WriteLine($"{user.firstName} {user.lastName} <{user.email}>");
Console.ReadKey();