namespace StudentManagementApp.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }

        // Navigation property
        public List<Student> Students { get; set; }
    }
}
