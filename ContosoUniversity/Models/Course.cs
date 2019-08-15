using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        //lets you enter the promary key for the course rahter tahn having the databse generate it
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        //navigation property. a course entity can be related to any number of Enrollment entities
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
