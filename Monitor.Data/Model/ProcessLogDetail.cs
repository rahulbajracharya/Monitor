using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Monitor.Data.Model
{
  public class ProcessLogDetail
  {
    public ProcessLogDetail()
    {
    
    }
    public long LogId { get; set; }
    public string Method { get; set; }
    public string Parameters { get; set; }
    public string Result { get; set; }
    public string Status { get; set; }
    public long TotalTimeMS { get; set; }
    public long TotalTicks { get; set; }
    public int ExceptionType { get; set; }
    public string ExceptionDetail { get; set; }
    public DateTime CrDateTime { get; set; }
    public string User { get; set; }
  }
}
