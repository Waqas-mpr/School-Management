﻿using School_Management.Dto;
using System.Collections.Generic;

namespace School_Management.Database
{
    internal  class  DataStore
    {
       
        public static List<Teacher> TeachersData()
        {
            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher() { Id=1,Name="Ali Raza",Age=30,NumberOfPublications=5},
                new Teacher() { Id=2,Name="Ahmed Ali",Age=30,NumberOfPublications=2}, 
                new Teacher() { Id=4,Name="Muhammad Ali",Age=30,NumberOfPublications=1}, };

            return teachers;
        }

        public static List<Student> StudentsData()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Id=3,Name="Ahmed",Age=30,Grade='A'},
                new Student() { Id=5,Name="Ali",Age=30,Grade='B'},
                new Student() { Id=6,Name="Usman",Age=30,Grade='C'}, };

            return students;
        }
    }
}
