using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monitor.Core.Model;
using Monitor.Data;

namespace Monitor.Core.Interface
{
  public interface ILoggerBL
  {
    string AddLog(ProcessLog ProcessLog);
  }
}
