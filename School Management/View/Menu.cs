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
        public void MenuSelector()
        {
            TeacherView _teacherView = new TeacherView();

            ConsoleKey pressedKey;

            do
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
                            else if (option == 2) { }
                            else Console.WriteLine("Choose Correct Option");
                            break;

                        case 4:
                            if (option == 1) { }
                            else if (option == 2)
                            {
                                _teacherView.GetAllTeachers();
                                Console.WriteLine("Choose Id to Delete Teacher.");
                                int id = DatatypeConverter.integerParse(Console.ReadLine());
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

            } while ((pressedKey = Console.ReadKey().Key) != ConsoleKey.Escape);

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

    }
}
