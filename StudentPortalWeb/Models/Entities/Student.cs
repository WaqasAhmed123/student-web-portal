using Microsoft.AspNetCore.Identity;

namespace StudentPortalWeb.Models.Entities
{
    public class Student: IdentityUser
    {
        public String Name { get; set; }
        public String Department { get; set; }
        public ICollection<Enrolment> Enrolments { get; set; } // Collection navigation property
    }

}


