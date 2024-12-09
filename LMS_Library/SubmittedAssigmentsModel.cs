using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Library
{
    public class SubmittedAssigmentsModel
    {
        public int Assignment_ID { get; set; }
        public AssignmentModel Assigment = new AssignmentModel();
        public StudentModel Student = new StudentModel();
        public CourseModel Course = new CourseModel();
    }
}
