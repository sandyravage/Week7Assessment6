namespace Assessment6Week7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttendanceDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "AttendanceDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "AttendanceDate");
        }
    }
}
