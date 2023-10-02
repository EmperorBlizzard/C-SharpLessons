using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Classes_Inheritance.Models
{
    internal class CompanyCustomer : Customer
    {
        public string CompanyName { get; set; } = null!;
        public string PhoneNummber { get; set;} = null!;
    }
}
