using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.IDAL
{
    public interface IRepository<T> where T : class
    {
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
        //IQueryable<T> GetAll();

        Task<IEnumerable<T>> GetAll();
        T GetById(int FindId);
        void Save();

    }
}
