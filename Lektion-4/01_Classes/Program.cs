using _01_Classes.Models;
using _01_Classes.Services;

/*
    Access Modifiers
    --------------------------------------------------------------------------------------------------------------------------------------

    private             accesbar bara inom scopet (dvs { }) som variabln ligger inom

    public              accessbar överallt i hela din solution, dvs även mellan olika projekt

    internal            accessbar överallt i hela ditt project, men inte mellan olika projekt
    
*/




//Vi gör en instans av en customerService så vi kan använda den
var custumerService = new CustomerService();


custumerService.CreateCustomer(new Customer()); 

custumerService.GetCustomers();
