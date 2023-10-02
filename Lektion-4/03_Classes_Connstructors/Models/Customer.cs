using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes_Connstructors.Models
{
    internal class Customer
    {
        public Customer()
        {
            
        }
        public Customer(string _name, string _email)
        {
            Name = _name;
            Email = _email;
        }
        public Customer(string _name, string _email, string _phoneNummber)
        {
            Name = _name;
            Email = _email;
            PhoneNummber = _phoneNummber;
        }

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = null!;
        public string? PhoneNummber { get; set; }

    }
}
