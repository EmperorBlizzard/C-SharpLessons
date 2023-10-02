namespace _02_Classes_GettersAndSetters.Models
{
    internal class Customer
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value.Trim(); }
        }

        

        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

    }
}
