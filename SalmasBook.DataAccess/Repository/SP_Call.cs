﻿using SalmasBook.DataAccess.Repository.IRepository;
using SalmasBookStore.DataAccess.Data;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace SalmasBook.DataAccess.Repository
{
    public class SP_Call : ISP_Call 
    {
        // access  the database
        private readonly ApplicationDbContext _db;
        private static string ConnectionString = ""; // needed to called the stored procedures

        // contructor to open a SQL connection
        public SP_Call(ApplicationDbContext db)
        {
            _db = db;
            ConnectionString = db.Database.GetDbConnection().ConnectionString;
        }


        // implements the ISP_Call interface
        public void Dispose()
        {
            throw new NotImplementedException();
            _db.Dispose();
        }

        public void Execute(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(procedurename, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procedurename, param, commandType: System.Data.CommandType.StoredProcedure);
            }
        }

        public Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                var result = SqlMapper.QueryMultiple(sqlCon, procedurename, param, commandType: System.Data.CommandType.StoredProcedure);
                var item1 = result.Read<T1>().ToList(); //make sure to add using statement for LINQ
                var item2 = result.Read<T2>().ToList();

                if (item1 != null && item2 != null)
                {
                    return new Tuple<IEnumerable<T1>, IEnumerable<T2>>(new List<T1>(), new List<T2>());
                }
            }
        }

        public T OneRecord<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                var value = sqlCon.Query<T>(procedurename, param, commandType: System.Data.CommandType.StoredProcedure);
                return (T)Convert.ChangeType(value.FirstOrDefault(), typeof(T));
            }
        }

        public T Single<T>(string procedurename, DynamicParameters param = null)
        {
            throw new NotImplementedException();
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                return (T)Convert.ChangeType(sqlCon.ExecuteScalar<T>(procedurename, param, commandType: System.Data.CommandType.StoredProcedure), typeof(T));
            }
        }
    }
}
