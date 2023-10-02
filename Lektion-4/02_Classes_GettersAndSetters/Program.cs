using _02_Classes_GettersAndSetters.Models;
using System.Text;

var customer = new Customer();


//set - sätter ett värde
customer.FirstName = "Emil";
customer.LastName = "Olsson";



//get  hämta värdet
var name = customer.FullName;









var user  = new User();
user.FirstName = "Emil";
user.LastName = "Olsson";
user.Email = "emil111@live.se";

user.SetSecurePassword("BytMig123!");

var password = Encoding.UTF8.GetString(user.Password);

Console.WriteLine(password);

Console.ReadKey();