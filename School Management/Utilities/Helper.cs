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
            int maxStudentId;
            int maxTeacherId;

            maxStudentId= _studentDataStore.Count != 0? _studentDataStore.Max(s => s.Id) : 0;

            maxTeacherId= _teacherDataStore.Count != 0 ? _teacherDataStore.Max(t => t.Id) : 0;
       

            if(maxStudentId > maxTeacherId)
                return maxStudentId +1;
            else
                return maxTeacherId +1;

        }
    }
}
