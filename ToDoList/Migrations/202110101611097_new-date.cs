namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ToDoes", "EklenmeZamani");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ToDoes", "EklenmeZamani", c => c.DateTime());
        }
    }
}
