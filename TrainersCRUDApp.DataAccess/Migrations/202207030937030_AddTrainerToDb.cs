namespace TrainersCRUDApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTrainerToDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Subject = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trainers");
        }
    }
}
