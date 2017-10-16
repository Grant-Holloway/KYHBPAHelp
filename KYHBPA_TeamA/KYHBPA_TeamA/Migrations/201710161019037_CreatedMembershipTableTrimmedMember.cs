namespace KYHBPA_TeamA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatedMembershipTableTrimmedMember : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Memberships",
                c => new
                    {
                        MembershipID = c.Int(nullable: false, identity: true),
                        MemberID = c.Int(nullable: false),
                        DateofBirth = c.DateTime(),
                        PhoneNumber = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        LicenseNumber = c.String(),
                        IsOwner = c.Boolean(nullable: false),
                        IsTrainer = c.Boolean(nullable: false),
                        IsOwnerAndTrainer = c.Boolean(nullable: false),
                        AgreedToTerms = c.Boolean(nullable: false),
                        Signature = c.String(),
                        Affiliation = c.String(),
                        ManagingPartner = c.String(),
                    })
                .PrimaryKey(t => t.MembershipID);
            
            AddColumn("dbo.Members", "Membership_MembershipID", c => c.Int());
            CreateIndex("dbo.Members", "Membership_MembershipID");
            AddForeignKey("dbo.Members", "Membership_MembershipID", "dbo.Memberships", "MembershipID");
            DropColumn("dbo.Members", "DateofBirth");
            DropColumn("dbo.Members", "MembershipEnrollment");
            DropColumn("dbo.Members", "Income");
            DropColumn("dbo.Members", "PhoneNumber");
            DropColumn("dbo.Members", "Address");
            DropColumn("dbo.Members", "City");
            DropColumn("dbo.Members", "State");
            DropColumn("dbo.Members", "ZipCode");
            DropColumn("dbo.Members", "LicenseNumber");
            DropColumn("dbo.Members", "IsOwner");
            DropColumn("dbo.Members", "IsTrainer");
            DropColumn("dbo.Members", "IsOwnerAndTrainer");
            DropColumn("dbo.Members", "AgreedToTerms");
            DropColumn("dbo.Members", "Signature");
            DropColumn("dbo.Members", "Affiliation");
            DropColumn("dbo.Members", "ManagingPartner");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "ManagingPartner", c => c.String());
            AddColumn("dbo.Members", "Affiliation", c => c.String());
            AddColumn("dbo.Members", "Signature", c => c.String());
            AddColumn("dbo.Members", "AgreedToTerms", c => c.Boolean(nullable: false));
            AddColumn("dbo.Members", "IsOwnerAndTrainer", c => c.Boolean(nullable: false));
            AddColumn("dbo.Members", "IsTrainer", c => c.Boolean(nullable: false));
            AddColumn("dbo.Members", "IsOwner", c => c.Boolean(nullable: false));
            AddColumn("dbo.Members", "LicenseNumber", c => c.String());
            AddColumn("dbo.Members", "ZipCode", c => c.String());
            AddColumn("dbo.Members", "State", c => c.String());
            AddColumn("dbo.Members", "City", c => c.String());
            AddColumn("dbo.Members", "Address", c => c.String());
            AddColumn("dbo.Members", "PhoneNumber", c => c.String());
            AddColumn("dbo.Members", "Income", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Members", "MembershipEnrollment", c => c.DateTime(nullable: false));
            AddColumn("dbo.Members", "DateofBirth", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Members", "Membership_MembershipID", "dbo.Memberships");
            DropIndex("dbo.Members", new[] { "Membership_MembershipID" });
            DropColumn("dbo.Members", "Membership_MembershipID");
            DropTable("dbo.Memberships");
        }
    }
}
