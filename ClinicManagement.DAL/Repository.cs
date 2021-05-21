using ClinicManagement.IDAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinicManagement.DAL
{
    public class Repository<T> : IRepository<T> where T : class 
    {
        private DbContext ClinicDAL = null;
        private DbSet<T> dbentity = null;
        public void Add(T obj)
        {
            this.ClinicDAL.Set<T>().Add(obj);
        }

        public void Delete(T obj)
        {
           this.ClinicDAL.Set<T>().Remove(obj);
        }

        public T GetById(int FindId)
        {
            return  ClinicDAL.Set<T>().Find(FindId);
        }

        public IQueryable<T> GetAll()
        {
             return ClinicDAL.Set<T>().AsNoTracking();
        }

        public void Save()
        {
            ClinicDAL.SaveChanges();
        }

        public void Update(T obj)
        {
            this.ClinicDAL.Set<T>().Update(obj);
        }
    }
}
