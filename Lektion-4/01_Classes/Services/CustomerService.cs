using _01_Classes.Models;

namespace _01_Classes.Services
{
    internal class CustomerService
    {
        //service = 90% Methodes

        //fields
        private List<Customer> _customerList;


        //Constructors
        public CustomerService()
        {
            
        }

        //Properties

        //Methods
        public void CreateCustomer(Customer customer) 
        {
            Console.WriteLine("First Name");
            customer.FirstName = Console.ReadLine();
            Console.WriteLine("Last Name");
            customer.LastName = Console.ReadLine();
            Console.WriteLine("Email");
            customer.Email = Console.ReadLine();
            Console.WriteLine("Phone Number");
            customer.PhoneNumber = Console.ReadLine();
            
            _customerList.Add(customer);
        }
        public void GetCustomer() 
        {

        }
        public List<Customer> GetCustomers() 
        {
            return _customerList.OrderBy(x => x.Id).ToList();
        }
        public void UpdateCustomer() 
        {

        }
        public void DeleteCustomer() 
        {

        }

    }
}
