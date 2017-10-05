using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Monitor.Data.Common
{
 public class ConnectionFactory
  {
   static SqlConnection conn = new SqlConnection();
    public static IDbConnection GetConnection()
   {
     try
     {
       if(conn.State!=System.Data.ConnectionState.Open)
       {
         conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MonitorEntities"].ConnectionString);
         conn.Open();
       }
       return conn;
     }
      catch (Exception ex)
     {
       return null;
     }
   }
 
  }
}
