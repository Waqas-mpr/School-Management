using School_Management.BusinessLogic;
using School_Management.Dto;
using School_Management.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management.View
{
    internal class StudentView
    {
        StudentRepository _repository = new StudentRepository();
        public void Printer(Student student)
        {
            Console.WriteLine("{0}:     {1},                 {2 },    {3}", student.Id, student.Name, student.Age, student.Grade);
        }

        public List<Student> GetAllStudents()
        {
            var students = _repository.GetAll();

            return students;

        }

        public void AddTeacher(Student student)
        {
            var addedStudent = _repository.Add(student);

            if (addedStudent != null)
            {
                Console.WriteLine("Sccussfully Addded.");
                Printer(addedStudent);
            }
            else
            {
                Console.WriteLine("No Record Added.");
            }
        }
        public Student createStudent()
        {

            Console.WriteLine("Please Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter Age:");
            int age = DatatypeConverter.IntegerParse(Console.ReadLine());
            Console.WriteLine("Please Enter Grade");
            char grade = DatatypeConverter.CharParse(Console.ReadLine());
            return new Student()
            {
                Name = name,
                Age = age,
                Grade = grade
            };
        }

        public void DeleteStudent(Student student)
        {
            bool isDeleted = _repository.Delete(student);
            if (isDeleted)
            {
                Console.WriteLine($"Sccussfully Deleted {student.Name}");
            }
        }

        public void UpdateStudent(Student student)
        {

            _repository.Update(student);
        }

        public Student SelectStudent(int id)
        {
            return GetAllStudents().Where(t => t.Id == id).FirstOrDefault();
        }

        public void StudentsSentToPrinter(List<Student> students)
        {

            Console.WriteLine("Students:");
            Console.WriteLine("-------------------------------------------------");

            foreach (var student in students)
                Printer(student);
        }

    }
}
