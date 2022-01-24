using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

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
            Name = name;
            Surname = surname;
            Group = group;
            Faculty = faculty;
        }

        public static void AddToList(string namep, string surnamep, int groupp, string facultyp)
        {
            Student std = new Student(namep, surnamep, groupp, facultyp);
            stud.Add(std);
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

        public void Add(Student studi)
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("Persons");
            var collection = db.GetCollection<Student>("person");
            collection.InsertOne(studi);
            var list = collection.Find(x => true).ToList(); // лист передаю в компонетнт
        }

        static void Main(string[] args)
        {
            MongoClient dbClient = new MongoClient();

            var dbList = dbClient.ListDatabases().ToList();

            Console.WriteLine("The list of databases on this server is: ");
            foreach (var db in dbList)
            {
                Console.WriteLine(db);
            }
        }

    }


}
