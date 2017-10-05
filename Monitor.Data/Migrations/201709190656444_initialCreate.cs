namespace Monitor.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExceptionTypes",
                c => new
                    {
                        ExcId = c.Int(nullable: false, identity: true),
                        ExcType = c.String(),
                        CrDatetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ExcId);
            
            CreateTable(
                "dbo.ProcessLogDetails",
                c => new
                    {
                        LogId = c.Long(nullable: false, identity: true),
                        Parameters = c.String(),
                        Result = c.String(),
                        Status = c.String(),
                        TotalTimeMS = c.Long(nullable: false),
                        TotalTicks = c.Int(nullable: false),
                        ExceptionType = c.Int(nullable: false),
                        ExceptionDetail = c.String(),
                        CrDateTime = c.DateTime(nullable: false),
                        User = c.String(),
                    })
                .PrimaryKey(t => t.LogId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProcessLogDetails");
            DropTable("dbo.ExceptionTypes");
        }
    }
}
