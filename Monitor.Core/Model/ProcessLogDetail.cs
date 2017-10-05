using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Monitor.Core.Model
{
  public class ProcessLog
  {
    public ProcessLog()
    {
    
    }
    public long LogId { get; set; }
    public string Parameters { get; set; }
    public string Result { get; set; }
    public string Status { get; set; }
    public long TotalTimeMS { get; set; }
    public long TotalTicks { get; set; }
    public int ExceptionType { get; set; }
    public string ExceptionDetail { get; set; }
    public DateTime CrDateTime { get; set; }
    public string Method { get; set; }
    public string User { get; set; }
  }
}
