

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        //primary key
        public int EnrollemntID { get; set; }
        //foreign key and corresponding navigation prop is Course
        public int CourseID { get; set; }
        //foreign key
        public int StudentID { get; set; }
        //grade is an enum and the ? means it is nullable and not known yet, not a zero
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        // corresponding navigation property of StudentID
        public Student Student { get; set; }
    }
}
