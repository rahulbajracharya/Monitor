using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monitor.Data.Common;
using System.Data.SqlClient;
using Monitor.Data.Model;
using Dapper;

namespace Monitor.Data.Dapper
{
 public class MonitorDapperEntities
  {
    public string AddLog(ProcessLogDetail ProcessLog)
   {
     using (var conn = ConnectionFactory.GetConnection())
     {
       try
       {
         string sqlQuery = "Insert Into ProcessLogDetails(Parameters,Method,Result,Status,TotalTimeMS,TotalTicks,ExceptionType,ExceptionDetail,CrDateTime) Values(@Parameters,@Method,@Result,@Status,@TotalTimeMS,@TotalTicks,@ExceptionType,@ExceptionDetail,@CrDateTime)";
         conn.Execute(sqlQuery, new { Parameters = ProcessLog.Parameters, ProcessLog.Method, Result = ProcessLog.Result, Status = ProcessLog.Status, TotalTimeMS = ProcessLog.TotalTimeMS, TotalTicks = ProcessLog.TotalTicks, ExceptionType = ProcessLog.ExceptionType, ExceptionDetail = ProcessLog.ExceptionDetail, CrDateTime = ProcessLog.CrDateTime });
         return "Success";
       }
       catch (Exception ex)
       {
         return ex.ToString();
       }
     }
   }
  }
}
