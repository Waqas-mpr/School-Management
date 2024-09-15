using School_Management.Dto;
using School_Management.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management.View
{
    internal class Menu
    {
        TeacherView _teacherView = new TeacherView();
        public void MenuSelector()
        {

            Console.WriteLine("Press Any Key to Start App, Press Esc Key to Exit App. ");
            ConsoleKey pressedKey;

            while ((pressedKey = Console.ReadKey().Key) != ConsoleKey.Escape)
            {
                Console.Clear();
                DisplayOperations();
                int operation = DatatypeConverter.integerParse(Console.ReadLine());

                if (operation >= 1 && operation <= 4)
                {
                    DiplayMenu();

                    int option = DatatypeConverter.integerParse(Console.ReadLine());

                    switch (operation)
                    {
                        case 1:
                            if (option == 1) { }

                            else if (option == 2)
                            {
                                Teacher createTeacher = _teacherView.createTeacher();
                                _teacherView.AddTeacher(createTeacher);

                            }
                            else Console.WriteLine("Choose Correct Option");
                            break;

                        case 2:
                            if (option == 1) { }
                            else if (option == 2)
                            {
                                _teacherView.TeachersSentToPrinter(_teacherView.GetAllTeachers());
                            }
                            else Console.WriteLine("Choose Correct Option");
                            break;
                        case 3:
                            if (option == 1) { }
                            else if (option == 2)
                            {


                                int id = ShowTeachersToSelectTeacherId("Edit");
                                Teacher selectedTeacher = _teacherView.SelectTeacher(id);


                                DiplayPropertyMenu();
                                int selectProperty = DatatypeConverter.integerParse(Console.ReadLine());


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
                                        int age = DatatypeConverter.integerParse(Console.ReadLine());
                                        selectedTeacher.Age = age;
                                        _teacherView.UpdateTeacher(selectedTeacher);
                                        break;
                                    case 3:
                                        Console.WriteLine("Please Enter No. of Publications");
                                        int numberOfPublications = DatatypeConverter.integerParse(Console.ReadLine());
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
                            if (option == 1) { }
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

        void DiplayPropertyMenu()
        {
            Console.WriteLine("Choose Your option to Edit [1,2,3]: ");
            Console.WriteLine("[1]. Name");
            Console.WriteLine("[2]. Age");
            Console.WriteLine("[3]. No. of Publications");
        }

        int ShowTeachersToSelectTeacherId(String operationMessage)
        {
            _teacherView.TeachersSentToPrinter(_teacherView.GetAllTeachers());
            Console.WriteLine();
            Console.Write($"Choose Id to {operationMessage} Teacher:  ");
            return DatatypeConverter.integerParse(Console.ReadLine());
        }

    }
}
