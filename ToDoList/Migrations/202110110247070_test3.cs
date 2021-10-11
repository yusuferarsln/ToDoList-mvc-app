namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToDoes", "DateTime", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ToDoes", "DateTime");
        }
    }
}
