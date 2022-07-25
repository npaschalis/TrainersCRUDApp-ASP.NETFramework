namespace TrainersCRUDApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedValidationsToTrainerModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Trainers", "Subject", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Trainers", "Subject", c => c.String());
        }
    }
}
