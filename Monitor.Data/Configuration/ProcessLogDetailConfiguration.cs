using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Monitor.Data.Model;

namespace Monitor.Data.Configuration
{
  class ProcessLogDetailConfiguration: EntityTypeConfiguration<ProcessLogDetail>
  {
    public ProcessLogDetailConfiguration()
    {
      this.HasKey(p => p.LogId);
    }
  }
}
