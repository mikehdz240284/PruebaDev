using SilWMS.Framework.EntityBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace SilWMS.Framework.IBaseManager
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Insert(T entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        T GetBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="includes"></param>
        /// <returns></returns>
        IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes);

        /// <summary>
        /// Genera una consulta con los paremetros
        /// </summary>
        /// <param name="predicate">Predicados para la busqueda</param>
        /// <param name="includes">Predicados para la busqueda</param>
        /// <returns></returns>
        IQueryable<T> QueryOver(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

        /// <summary>
        /// Ejecuta un comando de tipo texto
        /// </summary>
        /// <param name="sql">comando</param>
        /// <param name="parameters">parametros</param>
        /// <returns></returns>
        DataSet ExecuteWithStoreProcedure(string sql);

        /// <summary>
        /// Agrega parametro a la consulta
        /// </summary>
        /// <param name="param">parametro</param>
        void AddParameter(object param);

        /// <summary>
        /// Agrega parametro nulo a la consulta
        /// </summary>
        void AddParameter();

        /// <summary>
        /// Limpia la lista de parametros
        /// </summary>
        void ResetParameters();
    }
}
