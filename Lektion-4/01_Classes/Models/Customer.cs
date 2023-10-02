namespace _01_Classes.Models
{
    internal class Customer
    {
        //model = 90% Properties

        //fields
        
        //Constructors

        //Properties
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        //Methods

    }
}
