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


            //var _isIdAvailable = _dataStore.Where(t => t.Id == entity.Id);

            //if (_isIdAvailable == null)
                _dataStore.Add(entity);

            return entity;


        }

     

        bool IRepository<Teacher>.Delete(Teacher entity)
        {
            throw new NotImplementedException();
        }

        public List<Teacher> GetAll()
        {
            return _dataStore;
        }

        Teacher IRepository<Teacher>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        Teacher IRepository<Teacher>.Update(Teacher entity)
        {
            throw new NotImplementedException();
        }
    }
}
