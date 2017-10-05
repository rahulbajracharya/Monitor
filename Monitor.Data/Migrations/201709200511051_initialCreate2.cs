namespace Monitor.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreate2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ProcessLogDetails", "TotalTicks", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProcessLogDetails", "TotalTicks", c => c.Int(nullable: false));
        }
    }
}
