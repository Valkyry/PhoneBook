using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SimplePhoneBook.Domain.Interfaces
{
    public interface IRepository<TEntity, in TStruct>
        where TEntity : class
        where TStruct : struct
    {
        /// <summary>
        /// اضافه کردن
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TEntity Add(TEntity entity);
        /// <summary>
        /// بررسی تعداد
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        int Count(Expression<Func<TEntity, bool>> where);
        /// <summary>
        /// تعداد
        /// </summary>
        /// <returns></returns>
        int Count();
        /// <summary>
        /// حذف
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        bool Delete(TEntity entity);
        /// <summary>
        /// خذف با شرط
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        bool Delete(Expression<Func<TEntity, bool>> where);
        /// <summary>
        /// بررسی وجود با شرط
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        bool Exists(Expression<Func<TEntity, bool>> predicate);
        /// <summary>
        /// گرفتن لیست 
        /// </summary>
        /// <returns></returns>
        ICollection<TEntity> Get();
        /// <summary>
        /// گرفتن تکی
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity Get(TStruct id);
        /// <summary>
        /// گرفتن لیست با شرط
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        ICollection<TEntity> Get(Expression<Func<TEntity, bool>> where);
        /// <summary>
        /// گرفتن لیست با شرط و محدودیت
        /// </summary>
        /// <param name="where"></param>
        /// <param name="take"></param>
        /// <param name="skip"></param>
        /// <returns></returns>
        ICollection<TEntity> GetLimit(Expression<Func<TEntity, bool>> where, int take, int skip);
        /// <summary>
        /// ویرایش
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TEntity Update(TEntity entity);
    }

}
