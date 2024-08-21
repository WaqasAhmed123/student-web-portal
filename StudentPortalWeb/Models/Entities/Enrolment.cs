namespace StudentPortalWeb.Models.Entities
{
    public class Enrolment
    {
        public Guid EnrolmentId { get; set; }

        // Foreign key to Student
        public String StudentId { get; set; }
        public Student Student { get; set; } // Navigation property

        // Foreign key to Course
        public Guid CourseId { get; set; }
        public Course Course { get; set; } // Navigation property

        public DateTime EnrollmentDate { get; set; }
    }
}
