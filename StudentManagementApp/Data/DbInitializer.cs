using StudentManagementApp.Models;

namespace StudentManagementApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.Database.EnsureCreated(); // Creates DB if not exists

            // Check if Courses already seeded
            if (context.Courses.Any())
                return;

            var courses = new Course[]
            {
                new Course { CourseName = "Mathematics" },
                new Course { CourseName = "Science" },
                new Course { CourseName = "English" }
            };
            context.Courses.AddRange(courses);
            context.SaveChanges();

            var students = new Student[]
            {
                new Student { Name = "Alice", City = "Colombo", CourseID = courses[0].CourseID },
                new Student { Name = "Bob", City = "Kandy", CourseID = courses[1].CourseID },
                new Student { Name = "Charlie", City = "Galle", CourseID = courses[2].CourseID }
            };
            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}
