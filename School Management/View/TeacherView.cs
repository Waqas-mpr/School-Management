using School_Management.BusinessLogic;
using School_Management.Dto;
using School_Management.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace School_Management.View
{
    internal class TeacherView
    {
        TeacherRepository _repository = new TeacherRepository();
        public void Printer(Teacher teacher)
        {
            Console.WriteLine("{0}:     {1},                 {2 },    {3}", teacher.Id, teacher.Name, teacher.Age, teacher.NumberOfPublications);
        }

        public List<Teacher> GetAllTeachers()
        {
            var teachers = _repository.GetAll();

            return teachers;

        }

        public void AddTeacher(Teacher teacher)
        {
           var addedTeacher=  _repository.Add(teacher);

            if (addedTeacher != null)
            {
                Console.WriteLine("Sccussfully Addded.");
                Printer(addedTeacher);
            }
            else
            {
                Console.WriteLine("No Record Added.");
            }
        }
        public Teacher createTeacher()
        {

            Console.WriteLine("Please Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter Age:");
            int age = DatatypeConverter.IntegerParse(Console.ReadLine());
            Console.WriteLine("Please Enter No. of Publications");
            int numberOfPublications = DatatypeConverter.IntegerParse(Console.ReadLine());
            return new Teacher()
            {
                Name = name,
                Age = age,
                NumberOfPublications = numberOfPublications
            };
        }

        public void DeleteTeacher(Teacher teacher)
        {
           bool isDeleted= _repository.Delete(teacher);
            if (isDeleted)
            {
                Console.WriteLine($"Sccussfully Deleted {teacher.Name}");
            }
        }

        public void UpdateTeacher(Teacher teacher)
        {
          
            _repository.Update(teacher);    
        }

        public Teacher SelectTeacher(int id)
        {
           return GetAllTeachers().Where(t => t.Id == id).FirstOrDefault();
        }

        public void TeachersSentToPrinter(List<Teacher> teachers)
        {

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");

            foreach (var teacher in teachers)
                Printer(teacher);
        }


    }
}
