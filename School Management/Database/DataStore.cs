using School_Management.Dto;
using System.Collections.Generic;

namespace School_Management.Database
{
    internal class DataStore
    {

        List<Teacher> _teachers;
        List<Student> _students;
        private DataStore()
        {
            _teachers = new List<Teacher>();
            _students = new List<Student>();
        }
        private static readonly DataStore _dataStore = new DataStore();


        public static DataStore GetInstance { get { return _dataStore; } }
      
        public List<Teacher> TeachersData()
        {
            
            _teachers.Add(
                new Teacher() { Id = 1, Name = "Ali Raza", Age = 30, NumberOfPublications = 5 }
               );

            _teachers.Add(
              new Teacher() { Id = 2, Name = "Ahmed Ali", Age = 25, NumberOfPublications = 2 }
              );
            _teachers.Add(
               new Teacher() { Id = 4, Name = "Muhammad Ali", Age = 28, NumberOfPublications = 1 }
              );

            return _teachers;
        }

        public  List<Student> StudentsData()
        {
            _students.Add(
                 new Student() { Id = 3, Name = "Ahmed", Age = 10, Grade = 'A' }
               );

            _students.Add(
             new Student() { Id = 5, Name = "Ali", Age = 15, Grade = 'B' }
              );
            _students.Add(
               new Student() { Id = 6, Name = "Usman", Age = 16, Grade = 'C' }
              );

            return _students;
        }
    }
}
