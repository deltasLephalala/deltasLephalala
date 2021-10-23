using Microsoft.AspNetCore.Identity;

namespace AOLC_WebApplication.Data
{
    public class AolcUser : IdentityUser
    {
        [PersonalData]

        public string FirstName { get; set; }

        [PersonalData]

        public string LastName { get; set; }

        [PersonalData]
        public string Designation { get; set; }

        [PersonalData]
        public string CompanyName { get; set; }

        [PersonalData]
        public string Province { get; set; }

        [PersonalData]
        public string City { get; set; }

        [PersonalData]
        public string Address1 { get; set; }

        [PersonalData]
        public string Address2 { get; set; }
    }
}
