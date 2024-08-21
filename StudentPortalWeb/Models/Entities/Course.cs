namespace StudentPortalWeb.Models.Entities
{
    public class Course
    {
        public Guid CourseId { get; set; } 
        public string CourseName { get; set; }    
        public int CourseCode{ get; set; }

        // Navigation property for Enrolments
        public ICollection<Enrolment> Enrolments { get; set; }


    }
}
