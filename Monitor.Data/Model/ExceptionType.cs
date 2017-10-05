using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Monitor.Data.Model
{
  class ExceptionType
  {
    public ExceptionType()
    {

    }
    public int ExcId { get; set; }
    public string ExcType { get; set; }
    public DateTime CrDatetime { get; set; }
  }
}
