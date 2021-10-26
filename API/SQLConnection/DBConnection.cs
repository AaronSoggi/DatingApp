using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API.SQLConnection
{
    public interface IDBConnection 
    {
        SqlConnection GetConnection();
        
    }
    public class DBConnection : IDBConnection
    {
        public SqlConnection con = new SqlConnection(@"Server=(localdb)\\MSSQLLocalDB;DataBase=DatingSite;Trusted_Connection=True");
        public SqlConnection GetConnection()
        {
            return con;
        }
    }
}
