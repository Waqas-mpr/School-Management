using School_Management.Database;
using School_Management.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace School_Management.Utilities
{
    internal static class Helper
    {
        private static List<Teacher> _teacherDataStore = DataStore.GetInstance.TeachersData();
        private static List<Student> _studentDataStore = DataStore.GetInstance.StudentsData();
        public static int GenerateId()
        {
            int maxStudentId;
            int maxTeacherId;

            maxStudentId = _studentDataStore.Count != 0 ? _studentDataStore.Max(s => s.Id) : 0;

            maxTeacherId = _teacherDataStore.Count != 0 ? _teacherDataStore.Max(t => t.Id) : 0;


            if (maxStudentId > maxTeacherId)
                return maxStudentId + 1;
            else
                return maxTeacherId + 1;

        }


        public static string RequiredStringField(string title)
        {
            string text;
            while (true)
            {
                Console.Write($"\nPlease Enter {title}:  ");
                text = Console.ReadLine();

                if (String.IsNullOrEmpty(text))
                    Console.WriteLine("Name is Required Field.");
                else
                    break;
            }

            return text;
        }

        public static int RequiredIntergerField(string title)
        {
            int number;
            while (true)
            {
                Console.Write($"\nPlease Enter {title}:  ");

                string text = Console.ReadLine();

                if (String.IsNullOrEmpty(text))
                {
                    Console.WriteLine($"{title} is Required Field.");

                }
              
                else
                {
                    number = DatatypeConverter.IntegerParse(text);
                    break;
                }
            }

            return number;
        }


        public static char RequiredCharField(string title)
        {
            char character;
            while (true)
            {
                Console.Write($"\nPlease Enter {title}:  ");
                
                string text = Console.ReadLine();

                if (String.IsNullOrEmpty(text))
                {
                    Console.WriteLine($"{title} is Required Field.");

                }

               else if(text.Length>1)
                    Console.WriteLine($"{title} is Required Single Character.");
                else
                {
                    character = DatatypeConverter.CharParse(text);
                    break;
                }
            }

            return character;
        }


    }
}
