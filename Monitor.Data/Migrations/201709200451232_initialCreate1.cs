namespace Monitor.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProcessLogDetails", "Method", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProcessLogDetails", "Method");
        }
    }
}
