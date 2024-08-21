using Microsoft.AspNetCore.Identity;

namespace StudentPortalWeb.Models.Entities
{
    public class Student: IdentityUser
    {
        public string Name { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public ICollection<Enrolment> Enrolments { get; set; } = new List<Enrolment>();
    }

}


