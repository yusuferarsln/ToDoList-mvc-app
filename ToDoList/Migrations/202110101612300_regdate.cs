namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class regdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToDoes", "RegistrationDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ToDoes", "RegistrationDate");
        }
    }
}
