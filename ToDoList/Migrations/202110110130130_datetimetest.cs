namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetimetest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToDoes", "IssueDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ToDoes", "IssueDate");
        }
    }
}
