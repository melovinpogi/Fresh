using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FreshPros.DAL
{
    public class Config
    {
        public static IDbConnection CreateSQLConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["freshlawn"].ConnectionString);
        }        

    }
}