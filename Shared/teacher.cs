using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_API.Shared
{
    internal class teacher
    {
        [Key]
        public int TID { get; set; }
        public string name { get; set; }
        public IList<Course> Courses { get; set; }
    }
}
