using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Monitor.Data.Model;

namespace Monitor.Data.Configuration
{
  class ExceptionTypeConfiguration :EntityTypeConfiguration<ExceptionType>
  {
    public ExceptionTypeConfiguration()
    {
      this.HasKey(key => key.ExcId);
    }
  }
}
