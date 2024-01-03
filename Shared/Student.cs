using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_API.Shared
{
    internal class Student
    {
        public int StuId { get; set; }
        public string StuName { get; set; }
        public float marks { get; set; }

        public IList<Course> EnrolledCourses { get; set; }
    }
}
