using System;
using System.Data;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using SilWMS.Framework.EntityBase;
using System.Collections.Generic;
using System.Web.Compilation;
using System.Reflection;

namespace SilWMS.Framework.BaseContext
{
    /// <summary> 
    /// 
    /// </summary>
    public class DataBaseContext : DbContext, IDbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public DataBaseContext() : base("MiCadenaDeConexion")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public new DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            return base.Entry<TEntity>(entity);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public DataSet GetDataSet(string sql, CommandType commandType, List<object> parameters)
        {
            // creates resulting dataset
            var result = new DataSet();
            var param = string.Empty;

            // creates a Command 
            var cmd = Database.Connection.CreateCommand();
            cmd.CommandType = commandType;

            // adds all parameters
            for (int i = 0; i <= parameters.Count - 1; i++)
            {
                if(i > 0)
                {
                    param += ",";
                }
                if (parameters[i] == null)
                {
                    param += "null";
                }
                else
                {
                    param += "'" + parameters[i].ToString() + "'";
                }
            }

            cmd.CommandText = sql + ' ' + param;

            try
            {
                // executes
                Database.Connection.Open();
                var reader = cmd.ExecuteReader();

                // loop through all resultsets (considering that it's possible to have more than one)
                do
                {
                    // loads the DataTable (schema will be fetch automatically)
                    var tb = new DataTable();
                    tb.Load(reader);
                    result.Tables.Add(tb);

                } while (!reader.IsClosed);
            }
            finally
            {
                // closes the connection
                Database.Connection.Close();
            }

            // returns the DataSet
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //
            //DYNAMIC WAY OF MAPPING OUR ENTITIES
            var typesToRegister = AppDomain.CurrentDomain.GetAssemblies()
            //var typesToRegister = BuildManager.GetReferencedAssemblies().Cast<Assembly>()
                .SingleOrDefault(assembly => assembly.GetName().Name == "Persistence").GetTypes()
                .Where(type => !string.IsNullOrEmpty(type.Namespace))
                .Where(type => type.BaseType != null && type.BaseType.IsGenericType
                && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            //MANUAL WAY OF MAPPING OUR ENTITIES
            //modelBuilder.Configurations.Add(new AuthorMap());
            //modelBuilder.Configurations.Add(new BlogPostMap());

            base.OnModelCreating(modelBuilder);
        }
        
    }
}
