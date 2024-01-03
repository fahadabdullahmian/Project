using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_API.Shared
{
    internal class Course
    {
        [Key]
        public int cid { get; set; }
        public float marks { get; set; }

        
        public teacher CourseTeacher { get; set; }
        public IList<Student> EnrolledStudents { get; set; }
    }
}
