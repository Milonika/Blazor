using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class StudEx
    {
        public static string FrirsColum = "Name";
        public static string SecondColum = "Surname";
        public static string ThirdColum = "Group";
        public static string FourthColum = "Faculy";

        public static List<Student> StudentTable { get => Student.GetStudents();}
    }
}
