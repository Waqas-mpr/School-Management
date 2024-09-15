using School_Management.Database;
using School_Management.Dto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace School_Management.BusinessLogic
{
    internal class TeacherRepository : IRepository<Teacher>
    {

        private List<Teacher> _dataStore = DataStore.TeachersData();
        public Teacher Add(Teacher entity)
        {

            if (entity == null)
                return null;
            entity.Id = GenerateId();
            _dataStore.Add(entity);

            return entity;
        }



        public bool Delete(Teacher entity)
        {
            if (entity == null)
                return false;
            _dataStore.Remove(entity);
            return true;
        }

        public List<Teacher> GetAll()
        {
            return _dataStore;
        }

        public Teacher GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Teacher Update(Teacher entity)
        {
            if(entity == null)
                return null;
            Teacher findTeacher=_dataStore.Where(t=>t.Id==entity.Id).FirstOrDefault();

            findTeacher.Name = entity.Name;
            findTeacher.Age = entity.Age;
            findTeacher.NumberOfPublications= entity.NumberOfPublications;

            return findTeacher;
        }

        private int GenerateId()
        {
            return _dataStore.Max(t => t.Id) + 1;
        }
    }
}
