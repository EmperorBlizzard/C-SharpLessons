﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes_Connstructors.Models
{
    internal class User
    {


        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = null!;

    }
}
