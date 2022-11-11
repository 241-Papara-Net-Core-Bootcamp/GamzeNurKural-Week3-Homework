using GamzeNurKural_Week3_Homework.Data.Abstracts;
using GamzeNurKural_Week3_Homework.Data.Context;
using GamzeNurKural_Week3_Homework.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace GamzeNurKural_Week3_Homework.Data.Concretes
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public Week3DbContext Context { get; }

        public Repository(Week3DbContext context)
        {
            Context = context;
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
        }

        public int Delete(T entity)
        {
            T existData = Context.Set<T>().Find(entity.Id);
            if (existData != null && entity.Status != false)
            {
                existData.Status = false;
                Context.Entry(existData).State = EntityState.Modified;
                return Context.SaveChanges();
            }
            return -1;
        }

        public T GetById(int id)
        {
            return Context.Set<T>()
                .Where(x => x.Id == id && x.Status)
                .FirstOrDefault();
        }

        public IQueryable<T> GetAll()
        {
            return Context.Set<T>()
                .Where(x => x.Status)
                .AsQueryable();
        }

        public int HardDelete(T entity)
        {
            T existData = Context.Set<T>().Find(entity.Id);
            if (existData != null)
            {
                Context.Set<T>().Remove(existData);
                return Context.SaveChanges();
            }
            return -1;
        }

        public int Update(T entity)
        {
            T existData = Context.Set<T>().AsNoTracking().FirstOrDefault(x => x.Id == entity.Id);
            if (existData != null)
            {
                Context.Set<T>().Update(entity);
                return Context.SaveChanges();
            }
            return -1;
        }
    }
}
