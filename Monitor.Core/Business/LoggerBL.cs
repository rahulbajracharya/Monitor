using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monitor.Core.Model;
using Monitor.Core.Interface;
using Monitor.Data.Model;
using Monitor.Data.Dapper;
using AutoMapper;


namespace Monitor.Core.Business
{
  class LoggerBL: ILoggerBL
  {
    public string AddLog(ProcessLog ProcessLog1)
    {
      
      Mapper.Initialize(cfg => cfg.CreateMap<ProcessLog, ProcessLogDetail>());
      ProcessLogDetail log = Mapper.Map<ProcessLog, ProcessLogDetail>(ProcessLog1);
      try
      {
        var db = new MonitorDapperEntities();
        db.AddLog(log);
        return "Success";
      }
      catch (Exception ex)
      {
        return ex.ToString();
      }
    }
  }
}
