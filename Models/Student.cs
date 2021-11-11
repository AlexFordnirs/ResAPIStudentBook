using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Models
{
    public class Student
    {
        public int iD { get; set; }
        public string FIRST_NAME { get; set; }
        public string lAST_NAME { get; set; }
        public int AGE { get; set; }
    }
    public partial class GROUP_STUDENT
    {
        public int ID { get; set; }
        public string NAME_GROUP { get; set; }
        public string SPECIALIZ_GROUP { get; set; }
        public int STUDENT_ID { get; set; }
        public Student Student { get; set; }
    }
    public partial class StudentsHomeVork
    {
        public int ID { get; set; }
        public int GROUP_STUDENT_ID { get; set; }
        public string NAZVANIE_HOMEVORK { get; set; }
        public string ZADANIE { get; set; }
        public GROUP_STUDENT GROUP_STUDENT { get; set; }
    }
    public partial class StudentsRaspisanie
    {
        public int ID { get; set; }
        public DateTime DATE_SI_VORK_STUDENT { get; set; }
        public string NAZVANIE_PREDMETA { get; set; }
        public int GROUP_STUDENT_ID { get; set; }
        public GROUP_STUDENT GROUP_STUDENT { get; set; }
    }
}
