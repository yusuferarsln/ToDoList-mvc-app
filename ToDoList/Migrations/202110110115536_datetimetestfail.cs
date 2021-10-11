namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetimetestfail : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ToDoes", "IssueDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ToDoes", "IssueDate", c => c.DateTime(nullable: false));
        }
    }
}
