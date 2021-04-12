using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MongoRepository
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Tüm veriyi getirir
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();

        /// <summary>
        /// Where komutuna göre tüm verileri getirme 
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        IQueryable<T> GetAll(Expression<Func<T, bool >> condition);

        /// <summary>
        /// İstenilen veriyi single olarak verir
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        T Get(Expression<Func<T, bool>> condition);

        /// <summary>
        /// Veri ekler
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// Condition a göre veriler güncellenir
        /// </summary>
        /// <param name="condition"></param>
        void Update(Expression<Func<T, bool >> condition, T entity);

        /// <summary>
        /// Condition a göre verileri siler
        /// </summary>
        /// <param name="condition"></param>
        void Delete(Expression<Func<T, bool>> condition);



    }
}
