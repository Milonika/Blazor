using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Group { get; set; }
        public string Faculty { get; set; }
        static List<Student> stud = new List<Student>();

        public Student(string name, string surname, int group, string faculty)
        {
            name = Name;
            surname = Surname;
            group = Group;
            faculty = Faculty;
        }

        public static void AddToList(Student student)
        { 
            stud.Add(student);
        }
        
        public static List<Student> GetStudents()
        {
            //stud.Add(new Student() { Name = "Олег", Surname = "Егоров", Group = 321, Faculty = "Программист" });
            //stud.Add(new Student() { Name = "Талгат", Surname = "Яруллин", Group = 321, Faculty = "Программист" });
            //stud.Add(new Student() { Name = "Александр", Surname = "Краснов", Group = 321, Faculty = "Программист" });
            //stud.Add(new Student() { Name = "Полина", Surname = "Авдеева", Group = 325, Faculty = "Веб-разработчик" });
            //stud.Add(new Student() { Name = "Раиля", Surname = "Бакирова", Group = 324, Faculty = "Веб-разработчик" });
            return stud;
        }



    }


}
