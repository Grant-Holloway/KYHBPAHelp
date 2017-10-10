namespace KYHBPA_TeamA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedMemberAndMembership : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Memberships",
                c => new
                    {
                        MembershipID = c.Int(nullable: false, identity: true),
                        MemberID = c.Int(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        LicenseNumber = c.String(),
                        StableName = c.String(),
                        IsOwner = c.Boolean(nullable: false),
                        IsTrainer = c.Boolean(nullable: false),
                        IsOwnerAndTrainer = c.Boolean(nullable: false),
                        Affiliation = c.String(),
                        ManagingPartner = c.String(),
                        AgreedToTerms = c.Boolean(nullable: false),
                        Signature = c.String(),
                    })
                .PrimaryKey(t => t.MembershipID);
            
            AddColumn("dbo.Members", "Membership_MembershipID", c => c.Int());
            CreateIndex("dbo.Members", "Membership_MembershipID");
            AddForeignKey("dbo.Members", "Membership_MembershipID", "dbo.Memberships", "MembershipID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "Membership_MembershipID", "dbo.Memberships");
            DropIndex("dbo.Members", new[] { "Membership_MembershipID" });
            DropColumn("dbo.Members", "Membership_MembershipID");
            DropTable("dbo.Memberships");
        }
    }
}
