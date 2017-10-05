using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Monitor.Data.Configuration;

namespace Monitor.Data.Model
{
  class MonitorEntities :DbContext
  {
    public MonitorEntities()
      : base("name=MonitorDBEntities")
    {

    }
    public DbSet<ProcessLogDetail> ProcessLogDetail { get; set; }
    public DbSet<ExceptionType> ExceptionType { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Configurations.Add(new ProcessLogDetailConfiguration());
      modelBuilder.Configurations.Add(new ExceptionTypeConfiguration());
    }
  }
}
