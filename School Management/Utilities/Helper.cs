using School_Management.Database;
using School_Management.Dto;
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
            int maxStudentId = _studentDataStore.Max(s => s.Id);
            int maxTeacherId = _teacherDataStore.Max(t => t.Id);

            if(maxStudentId > maxTeacherId)
                return maxStudentId +1;
            else
                return maxTeacherId +1;

        }
    }
}
