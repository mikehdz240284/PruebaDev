using SilWMS.Framework.BaseContext;
using SilWMS.Framework.IBaseManager;
using System;
using System.Linq;
using System.Linq.Expressions;
using SilWMS.Framework.EntityBase;
using System.Data.Entity;
using System.Data;
using System.Collections.Generic;

namespace SilWMS.Framework.BaseManager
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly IDbContext _context;
        private IDbSet<T> _entities;
        private List<object> _parameters;

        /// <summary>
        /// 
        /// </summary>
        public GenericRepository()
        {
            _context = new DataBaseContext();
            _parameters = new List<object>();
        }

        /// <summary>
        /// 
        /// </summary>
        protected virtual IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _context.Set<T>();
                return _entities;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual IQueryable<T> Table
        {
            get
            {
                return this.Entities;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            this.Entities.Add(entity);
            this._context.SaveChanges();
        }

        public virtual void BulkInsert(List<T> entitys)
        {
            if (entitys == null || entitys.Count == 0)
                throw new ArgumentNullException("entity");

            this.Entities.BulkInsert(entitys);
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");
            this._context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            this._context.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            this.Entities.Add(entity);
            this._context.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public T GetBy(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            var result = GetAll(includes);
            return result.FirstOrDefault(predicate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="includes"></param>
        /// <returns></returns>
        public IQueryable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> set = Table.AsNoTracking();

            foreach (var include in includes)
            {
                set = set.Include(include);
            }

            return set.AsQueryable<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        public IQueryable<T> QueryOver(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> set = Table.AsNoTracking();

            foreach (var include in includes)
            {
                set = set.Include(include);
            }

            return set.AsQueryable<T>().Where(predicate);
        }

        /// <summary>
        /// Ejecuta un comando de tipo texto
        /// </summary>
        /// <param name="sql">comando</param>
        /// <param name="parameters">parametros</param>
        /// <returns></returns>
        public DataSet ExecuteWithStoreProcedure(string sql)
        {
            return this._context.GetDataSet(sql, CommandType.Text, _parameters);
        }

        /// <summary>
        /// Agrega parametro a la consulta
        /// </summary>
        /// <param name="param">parametro</param>
        public void AddParameter(object param)
        {
            _parameters.Add(param);
        }
        
        /// <summary>
        /// Agrega parametro nulo a la consulta
        /// </summary>
        public void AddParameter()
        {
            _parameters.Add(null);
        }

        /// <summary>
        /// Limpia la lista de parametros
        /// </summary>
        public void ResetParameters()
        {
            _parameters.Clear();
        }
    }
}
