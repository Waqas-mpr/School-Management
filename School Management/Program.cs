using School_Management.BusinessLogic;
using School_Management.Dto;
using System;

namespace School_Management
{
    public class Program
    {

        static void Main(string[] args)
        {
            var repository = new TeacherRepository();

            ConsoleKey pressedKey;

            do
            {
                Console.Clear();
                DisplayOperations();
                int operation = integerParse(Console.ReadLine());

                if (operation >= 1 && operation <= 4)
                {
                    DiplayMenu();

                    int option = integerParse(Console.ReadLine());

                    switch (operation)
                    {
                        case 1:
                            if (option == 1) { }
                            else if (option == 2) { repository.Add(createTeacher()); }
                            else Console.WriteLine("Choose Correct Option");
                            break;

                        case 2:
                            if (option == 1) { }
                            else if (option == 2)
                            {
                                var teachers = repository.GetAll();

                                Console.WriteLine();
                                Console.WriteLine("-------------------------------------------------");

                                foreach (var teacher in teachers)

                                    PrintTeacher(teacher);
                            }
                            else Console.WriteLine("Choose Correct Option");
                            break;
                        case 3:
                            if (option == 1) { }
                            else if (option == 2) { repository.Add(createTeacher()); }
                            else Console.WriteLine("Choose Correct Option");
                            break;

                        case 4:
                            if (option == 1) { }
                            else if (option == 2) { repository.Add(createTeacher()); }
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

            int integerParse(string value)
            {
                if (int.TryParse(value, out int number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine($"{value} is not a number");

                    return 0;
                }
            }
            Teacher createTeacher()
            {
                Console.WriteLine("Enter Id");
                int id = integerParse(Console.ReadLine());
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                Console.WriteLine("age");
                int age = integerParse(Console.ReadLine());
                Console.WriteLine("numberOfPublications");
                int numberOfPublications = integerParse(Console.ReadLine());
                return new Teacher()
                {
                    Id = id,
                    Name = name,
                    Age = age,
                    NumberOfPublications = numberOfPublications
                };
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

            void PrintTeacher(Teacher teacher)
            {
                Console.WriteLine("{0}:     {1},        {2 },    {3}", teacher.Id, teacher.Name, teacher.Age, teacher.NumberOfPublications);
            }



        }
    }
}
