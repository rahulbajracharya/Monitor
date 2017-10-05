using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;
using Monitor.Data;
using Monitor.Core.Interface;
using Monitor.Core.Business;
using Monitor.Core.Model;

namespace Monitor.Core.Logger
{
  public class Perf <T, T1>
  {
    ILoggerBL ExeLog;
    public Perf()
    {
      ExeLog = new LoggerBL();
    }
    /// <summary>
    /// Execute Log with generic return type
    /// </summary>
    /// <param name="Operation"></param>
    /// <param name="obj"></param>
    /// <returns></returns>
    /// 
      public T ExecuteLog(Func<T1, T> Operation, T1 obj)
      {
        ProcessLog ProcessLog = new ProcessLog();
        Stopwatch logwatch = new Stopwatch();
        logwatch.Start();
        string output = string.Empty;
        string parameters = string.Empty;
        string method = string.Empty;
        var dataReturn = default(T); 
        Stopwatch watch = new Stopwatch();
        try
        {
          Console.WriteLine("Begin Try Operation");
          parameters = JsonConvert.SerializeObject(obj).ToString();
          method = Operation.Method.ToString();
          Console.WriteLine(String.Format("Parameters: {0}", parameters));
          Console.WriteLine(String.Format("Begin Operation ==> {0}", method));
          watch.Start();
          dataReturn = Operation(obj);
          watch.Stop();
          output = JsonConvert.SerializeObject(dataReturn).ToString();
          Console.WriteLine(String.Format("Operation Output: {0}", output));
          Console.WriteLine(String.Format("Time Elasped: {0}", watch.Elapsed));
          Console.WriteLine("End Try==>Success");
        }
        catch (Exception ex)
        {
          Console.WriteLine(String.Format("Exception occured: {0}", ex));
        }
        logwatch.Stop();
        Console.WriteLine(String.Format("Total Log time=>>>>> {0}", logwatch.Elapsed));
        ProcessLog.Parameters = parameters;
        ProcessLog.Result = output;
        ProcessLog.Method = method;
        ProcessLog.TotalTicks = Convert.ToInt32(watch.ElapsedTicks);
        ProcessLog.TotalTimeMS = watch.ElapsedMilliseconds;
        ProcessLog.CrDateTime = DateTime.Now;
        ExeLog.AddLog(ProcessLog);
        return dataReturn;
      }

    

      /// <summary>
      /// Get Object property name with value in string.
      /// </summary>
      /// <param name="obj"></param>
      /// <returns></returns>
      //public string GetPropertyList(object obj)
      //{
      //  var props = obj.GetType().GetProperties();
      //  var sb = new StringBuilder();
      //  foreach (var p in props)
      //  {
      //    sb.AppendLine(p.Name + ": " + p.GetValue(obj, null));
      //  }
      //  return sb.ToString();
      //}
    }


  public class Perf <T>
  {
    ILoggerBL ExeLog;
    public Perf()
    {
      ExeLog = new LoggerBL();
    }
    
    public T ExecuteLog(Func<T> Operation)
    {
      Stopwatch logwatch = new Stopwatch();
      logwatch.Start();
      Stopwatch watch = new Stopwatch();
      string output = string.Empty;
      string method = string.Empty;
      var dataReturn = default(T); 
      try
      {
       Console.WriteLine("Begin Try Operation");
          //parameters = GetPropertyList(obj);
          //Console.WriteLine(String.Format("Parameters: {0}", parameters));
      
       Console.WriteLine(String.Format("Begin Operation ==> {0}", Operation.Method));
         
          watch.Start();
          dataReturn = Operation();
          watch.Stop();
        method = Operation.Method.ToString();
        output = JsonConvert.SerializeObject(dataReturn).ToString();
          Console.WriteLine(String.Format("Operation Output: {0}",output));
          Console.WriteLine("Operation End==>>>>>");
          Console.WriteLine(String.Format("Time Elasped==>>>: {0}", watch.Elapsed));
          Console.WriteLine("End Try==>Success");
          
      }
        catch (Exception ex)
        {
          Console.WriteLine(String.Format("Exception occured: {0}", ex));
        }
      logwatch.Stop();

      Console.WriteLine(String.Format("Total Log time=>>>>> {0}", logwatch.Elapsed));
      ProcessLog ProcessLog = new ProcessLog();
      ProcessLog.Result = output;
      ProcessLog.Method = method;
      ProcessLog.TotalTicks = Convert.ToInt64(watch.ElapsedTicks);
      ProcessLog.TotalTimeMS = watch.ElapsedMilliseconds;
      ProcessLog.CrDateTime = DateTime.Now;
      ExeLog.AddLog(ProcessLog);
      return dataReturn;
    }
  }

}
