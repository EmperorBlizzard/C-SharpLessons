using _04_Classes_Inheritance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Classes_Inheritance.Services
{
    internal class CustomerService
    {
        private List<Customer> _customers;
        public static void CreatePrivateCustomer()
        {
            var cusomer = new PrivateCustomer();
        }
        public static void CreateCompanyCustomer()
        {
            var customer = new CompanyCustomer();
        }
    }
}
