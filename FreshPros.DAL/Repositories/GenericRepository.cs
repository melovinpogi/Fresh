using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FreshPros.DAL.Repositories
{
    public class GenericRepository<T> where T : class
    {
        protected readonly IDbConnection _db;
        public T repo;

        public GenericRepository()
        {
            this._db = new SqlConnection(ConfigurationManager.ConnectionStrings["freshlawn"].ConnectionString);
        }

        public virtual long InsertRecord(T entity)
        {
            return (long)_db.Insert(entity);
        }


        public virtual int Update(T entity)
        {
            return _db.Update(entity);
        }

        public virtual T GetByID(long id)
        {
            T record = _db.Get<T>(id);

            if (record == null)
            {
                throw new Exception("Not found!");
            }
            else
            {
                return record;
            }
        }

        public virtual T GetSingleRecord(string tableName ,string whereClause, object parameters = null)
        {
            T record = _db.QueryFirstOrDefault<T>("SELECT * FROM " + tableName + " " + whereClause, parameters);

            return record;
        }



        public IEnumerable<T> GetAll()
        {
            return _db.GetList<T>();
        }

        public IEnumerable<T> GetAllSpecificRecords(string conditions, object parameters = null)
        {
            return _db.GetList<T>(conditions, parameters);
        }


        public virtual void Delete(long id)
        {
            _db.Delete<T>(GetByID(id));
        }

    }
}