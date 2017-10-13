namespace KYHBPA_TeamA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedDocumentsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Documents", "MimeType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Documents", "MimeType");
        }
    }
}
