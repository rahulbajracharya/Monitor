using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Monitor.Core.Model
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
