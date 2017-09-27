namespace KYHBPA_TeamA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMembership : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Memberships",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        StableName = c.String(),
                        MemberType = c.Int(nullable: false),
                        LicenseNumber = c.Int(nullable: false),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        FaxNumber = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        ESignature = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Members", "Membership_Id", c => c.Int());
            CreateIndex("dbo.Members", "Membership_Id");
            AddForeignKey("dbo.Members", "Membership_Id", "dbo.Memberships", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "Membership_Id", "dbo.Memberships");
            DropIndex("dbo.Members", new[] { "Membership_Id" });
            DropColumn("dbo.Members", "Membership_Id");
            DropTable("dbo.Memberships");
        }
    }
}
