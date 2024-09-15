using School_Management.Database;
using School_Management.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace School_Management.BusinessLogic
{
    internal class StudentRepository : IRepository<Student>
    {
        private List<Student> _dataStore = DataStore.StudentsData();
        public Student Add(Student entity)
        {

            if (entity == null)
                return null;
            entity.Id = GenerateId();
            _dataStore.Add(entity);

            return entity;
        }



        public bool Delete(Student entity)
        {
            if (entity == null)
                return false;
            _dataStore.Remove(entity);
            return true;
        }

        public List<Student> GetAll()
        {
            return _dataStore;
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Student Update(Student entity)
        {
            if (entity == null)
                return null;
            Student findStudent = _dataStore.Where(t => t.Id == entity.Id).FirstOrDefault();

            findStudent.Name = entity.Name;
            findStudent.Age = entity.Age;
            findStudent.Grade = entity.Grade;

            return findStudent;
        }

        private int GenerateId()
        {
            return _dataStore.Max(t => t.Id) + 1;
        }
    }
}
