using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AOLCWebApplication.Data
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        //public byte[] Image { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
       // public string Designation { get; set; }
       // public string Gender { get; set; }
        //public DateTime Dob { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        //public string Address2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Description { get; set; }
    }
}
