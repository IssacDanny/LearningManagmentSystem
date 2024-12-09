using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Library
{
    public class ClassModel
    {
        public int Class_ID { get; set; }
        public string Course_ID {  get; set; }
        public int Teacher_ID {  get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public string Course_Term { get; set; }
    }
}
