namespace MigrationsPractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTeam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Scores", "Team", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Scores", "Team");
        }
    }
}
