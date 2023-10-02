using _03_Classes_Connstructors.Models;

var customer_1 = new Customer();

customer_1.Id = 1;
customer_1.Name = "Emil Olsson";
customer_1.Email = "emil111@live.se";
customer_1.PhoneNummber = "12345678";

var customer_2 = new Customer
{
    Id = 1,
    Name = "Emil Olsson",
    Email = "emil111@live.se",
    PhoneNummber = "12345678"
};

var customer_3 = new Customer("Emil Olsson", "emil111@live.se");

var customer_4 = new Customer("Emil Olsson", "emil111@live.se", "12345678");
