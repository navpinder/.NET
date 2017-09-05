namespace Example_2908CodeToDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartment1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Dapartments", name: "Name", newName: "DeptName");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Dapartments", name: "DeptName", newName: "Name");
        }
    }
}
