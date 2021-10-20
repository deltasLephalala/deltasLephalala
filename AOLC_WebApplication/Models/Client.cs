﻿using System;
using System.Collections.Generic;

#nullable disable

namespace AOLC_WebApplication.Models
{
    public partial class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Description { get; set; }
    }
}