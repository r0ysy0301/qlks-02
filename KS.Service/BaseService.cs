﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using KS.Core.Model;
using KS.Core.Interface.Data;
using KS.Core.Interface.Service;
using KS.Common.Paging;

namespace KS.Service
{
    public abstract class BaseService<T> : IService<T> where T : PersistentEntity
    {
        protected readonly IRepository<T> Repository;
        protected readonly IUnitOfWork UnitOfWork;

        protected BaseService(IRepository<T> repository, IUnitOfWork unitOfWork)
        {
            this.Repository = repository;
            this.UnitOfWork = unitOfWork;
        }

        public IQueryable<T> Entities
        {
            get { return Repository.Entities; }
        }

        public IQueryable<T> GetAll()
        {
            return Repository.GetAll();
        }

        public IQueryable<T> GetAllReadOnly()
        {
            return Repository.GetAllReadOnly();
        }

        public T GetById(int id)
        {
            return Repository.GetById(id);
        }

        public T GetById(int? id)
        {
            return Repository.GetById(id);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return Repository.Get(where);
        }

        public void Add(T entity)
        {
            Repository.Add(entity);
            UnitOfWork.Commit();
        }

        public void Update(T entity)
        {
            Repository.Update(entity);
            UnitOfWork.Commit();
        }

        public void Delete(T entity)
        {
            Repository.Delete(entity);
            UnitOfWork.Commit();
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            Repository.Delete(where);
            UnitOfWork.Commit();
        }

        public IQueryable<T> GetMany(Expression<Func<T, bool>> where, int? maxHints = null)
        {
            return Repository.GetMany(where, maxHints);
        }

        public IPage<T> Page<TKey>(Expression<Func<T, bool>> where, Expression<Func<T, TKey>> orderBy, int currentPage, int pageSize, bool ascending = true)
        {
            return Repository.Page(where, orderBy, currentPage, pageSize, ascending);
        }

        public IPage<T> Page<TKey>(IQueryable<T> data, Expression<Func<T, TKey>> orderBy, int currentPage, int pageSize, bool ascending = true)
        {
            return Repository.Page(data, orderBy, currentPage, pageSize, ascending);
        }
    }
}
