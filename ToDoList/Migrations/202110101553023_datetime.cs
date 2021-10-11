namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datetime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToDoes", "EklenmeZamani", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ToDoes", "EklenmeZamani");
        }
    }
}
