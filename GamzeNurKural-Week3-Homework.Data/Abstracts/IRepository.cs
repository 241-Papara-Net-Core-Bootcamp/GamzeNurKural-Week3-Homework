using GamzeNurKural_Week3_Homework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace GamzeNurKural_Week3_Homework.Data.Abstracts
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        int Update(T entity);
        int Delete(T entity);
        int HardDelete(T entity);
    }
}
