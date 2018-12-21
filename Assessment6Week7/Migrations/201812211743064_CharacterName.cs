namespace Assessment6Week7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CharacterName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "CharacterName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "CharacterName");
        }
    }
}
