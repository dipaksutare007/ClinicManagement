using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicManagement.IDAL
{
    public interface IRepository<T> where T : class
    {
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
        IQueryable<T> GetAll();
        T GetById(int FindId);
        void Save();

    }
}
