namespace Example_2908CodeToDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddURL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dapartments",
                c => new
                    {
                        DeptId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                        AddURL = c.String(),
                    })
                .PrimaryKey(t => t.DeptId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Dapartments");
        }
    }
}
