namespace StudentManagementApp.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        // Foreign key
        public int CourseID { get; set; }

        // Navigation property
        public Course Course { get; set; }
    }
}
