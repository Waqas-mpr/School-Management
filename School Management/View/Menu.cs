using School_Management.Dto;
using School_Management.Utilities;
using System;

namespace School_Management.View
{
    internal class Menu
    {
        TeacherView _teacherView = new TeacherView();
        StudentView _studentView = new StudentView();
        public void MenuSelector()
        {

            Console.WriteLine("Press Any Key to Start App, Press Esc Key to Exit App. ");
            ConsoleKey pressedKey;

            while ((pressedKey = Console.ReadKey().Key) != ConsoleKey.Escape)
            {
                Console.Clear();
                DisplayOperations();
                int operation = DatatypeConverter.IntegerParse(Console.ReadLine());

                if (operation >= 1 && operation <= 4)
                {
                    DiplayMenu();

                    int option = DatatypeConverter.IntegerParse(Console.ReadLine());

                    switch (operation)
                    {
                        case 1:
                            if (option == 1) {
                                Student createStudent = _studentView.createStudent();
                                _studentView.AddTeacher(createStudent);
                            }

                            else if (option == 2)
                            {
                                Teacher createTeacher = _teacherView.createTeacher();
                                _teacherView.AddTeacher(createTeacher);

                            }
                            else Console.WriteLine("Choose Correct Option");
                            break;

                        case 2:
                            if (option == 1) { _studentView.StudentsSentToPrinter(_studentView.GetAllStudents()); }
                            else if (option == 2)
                            {
                                _teacherView.TeachersSentToPrinter(_teacherView.GetAllTeachers());
                            }
                            else Console.WriteLine("Choose Correct Option");
                            break;
                        case 3:
                            if (option == 1) {

                                int id = ShowStudentsToSelectStudentId("Edit");
                                Student selectedStudent = _studentView.SelectStudent(id);


                                DiplayPropertyMenu("Grade");
                                int selectProperty = DatatypeConverter.IntegerParse(Console.ReadLine());


                                switch (selectProperty)
                                {
                                    case 1:
                                        Console.WriteLine("Please Enter Name:");
                                        string name = Console.ReadLine();
                                        selectedStudent.Name = name;
                                        _studentView.UpdateStudent(selectedStudent);
                                        break;
                                    case 2:
                                        Console.WriteLine("Please Enter Age:");
                                        int age = DatatypeConverter.IntegerParse(Console.ReadLine());
                                        selectedStudent.Age = age;
                                        _studentView.UpdateStudent(selectedStudent);
                                        break;
                                    case 3:
                                        Console.WriteLine("Grade");
                                        char grade = DatatypeConverter.CharParse(Console.ReadLine());
                                        selectedStudent.Grade = grade;
                                        _studentView.UpdateStudent(selectedStudent);
                                        break;
                                    default:
                                        Console.WriteLine("Choose Correct Option");
                                        break;
                                }
                            }
                            else if (option == 2)
                            {
                                int id = ShowTeachersToSelectTeacherId("Edit");
                                Teacher selectedTeacher = _teacherView.SelectTeacher(id);


                                DiplayPropertyMenu("No. of Publications");
                                int selectProperty = DatatypeConverter.IntegerParse(Console.ReadLine());


                                switch (selectProperty)
                                {
                                    case 1:
                                        Console.WriteLine("Please Enter Name:");
                                        string name = Console.ReadLine();
                                        selectedTeacher.Name = name;
                                        _teacherView.UpdateTeacher(selectedTeacher);
                                        break;
                                    case 2:
                                        Console.WriteLine("Please Enter Age:");
                                        int age = DatatypeConverter.IntegerParse(Console.ReadLine());
                                        selectedTeacher.Age = age;
                                        _teacherView.UpdateTeacher(selectedTeacher);
                                        break;
                                    case 3:
                                        Console.WriteLine("Please Enter No. of Publications");
                                        int numberOfPublications = DatatypeConverter.IntegerParse(Console.ReadLine());
                                        selectedTeacher.NumberOfPublications = numberOfPublications;
                                        _teacherView.UpdateTeacher(selectedTeacher);
                                        break;
                                    default:
                                        Console.WriteLine("Choose Correct Option");
                                        break;
                                }
                            }



                            else Console.WriteLine("Choose Correct Option");
                            break;

                        case 4:
                            if (option == 1)
                            {
                                int id = ShowStudentsToSelectStudentId("Delete");
                                Student selectedSudent = _studentView.SelectStudent(id);

                                if (selectedSudent != null)
                                    _studentView.DeleteStudent(selectedSudent);
                            }
                            else if (option == 2)
                            {
                                int id = ShowTeachersToSelectTeacherId("Delete");
                                Teacher selectedTeacher = _teacherView.SelectTeacher(id);

                                if (selectedTeacher != null)
                                    _teacherView.DeleteTeacher(selectedTeacher);
                            }
                            else Console.WriteLine("Choose Correct Option");
                            break;
                        default:
                            Console.WriteLine("Choose Correct Option");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please Choose Correct Option, Press Enter to continue ");

                }

            }

        }

        void DisplayOperations()
        {
            Console.WriteLine("Choose Your option [1,2,3,4]: ");
            Console.WriteLine("[1]. Add");
            Console.WriteLine("[2]. View");
            Console.WriteLine("[3]. Edit");
            Console.WriteLine("[4]. Delete");

        }
        void DiplayMenu()
        {
            Console.WriteLine("Choose Your option [1,2]: ");
            Console.WriteLine("[1]. Student");
            Console.WriteLine("[2]. Teacher");
        }

        void DiplayPropertyMenu(String paramMessage)
        {
            Console.WriteLine("Choose Your option to Edit [1,2,3]: ");
            Console.WriteLine("[1]. Name");
            Console.WriteLine("[2]. Age");
            Console.WriteLine($"[3]. {paramMessage}");
        }

        int ShowTeachersToSelectTeacherId(String operationMessage)
        {
            _teacherView.TeachersSentToPrinter(_teacherView.GetAllTeachers());
            Console.WriteLine();
            Console.Write($"Choose Id to {operationMessage} Teacher:  ");
            return DatatypeConverter.IntegerParse(Console.ReadLine());
        }

        int ShowStudentsToSelectStudentId(String operationMessage)
        {
            _studentView.StudentsSentToPrinter(_studentView.GetAllStudents());
            Console.WriteLine();
            Console.Write($"Choose Id to {operationMessage} Student:  ");
            return DatatypeConverter.IntegerParse(Console.ReadLine());
        }

    }
}
