using SimplePhoneBook.Domain.Entities;
using SimplePhoneBook.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace SimplePhoneBook.Persistence
{
    public class Repository<TEntity, TStruct> : IRepository<TEntity, TStruct>
        where TEntity : BaseEntity<TStruct>
        where TStruct : struct
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IDbSet<TEntity> _dbSet;
        protected readonly DateTime _now;

        public Repository(IApplicationDbContextFactory contextFactory)
        {
            _context = (ApplicationDbContext)contextFactory.GetContext();
            _dbSet = _context.Set<TEntity>();
            _now = DateTime.Now;
        }

        public virtual TEntity Add(TEntity entity)
        {
            entity.CreateDate = _now;
            entity.LastModifiedDate = _now;
            _dbSet.Add(entity);

            return entity;
        }

        public virtual int Count(Expression<Func<TEntity, bool>> where)
        {
            return _dbSet.Count(where);
        }

        public virtual int Count()
        {
            return _dbSet.Count();
        }

        public virtual bool Delete(TEntity entity)
        {
            _dbSet.Remove(entity);

            return true;
        }

        public virtual bool Delete(Expression<Func<TEntity, bool>> where)
        {
            var entities = _dbSet.Where(where).AsEnumerable();
            foreach (var entity in entities)
                _dbSet.Remove(entity);

            return true;
        }

        public virtual bool Exists(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Any(predicate);
        }

        public virtual ICollection<TEntity> Get()
        {
            return _dbSet.ToList();
        }

        public virtual TEntity Get(TStruct id)
        {
            return _dbSet.Find(id);
        }

        public virtual ICollection<TEntity> Get(Expression<Func<TEntity, bool>> where)
        {
            return _dbSet.Where(where).ToList();
        }

        public virtual ICollection<TEntity> GetLimit(Expression<Func<TEntity, bool>> where, int take, int skip)
        {
            return _dbSet.Where(where).OrderBy(x => x.ID).Skip(skip).Take(take).ToList();
        }

        public virtual TEntity Update(TEntity entity)
        {
            var old = Get(entity.ID);
            _context.Entry(old).State = EntityState.Detached;

            entity.CreateDate = old.CreateDate;
            entity.LastModifiedDate = _now;

            _context.Entry(entity).State = EntityState.Modified;

            return entity;
        }
    }
}
