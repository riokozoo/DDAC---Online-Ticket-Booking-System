namespace OnlineTicket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUIATables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CargoFlights",
                c => new
                    {
                        CFID = c.Int(nullable: false, identity: true),
                        airLine = c.String(),
                        airCraft = c.String(),
                        source = c.String(),
                        destination = c.String(),
                        date = c.String(),
                        capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CFID);
            
            CreateTable(
                "dbo.PassengerFlights",
                c => new
                    {
                        PFID = c.Int(nullable: false, identity: true),
                        airLine = c.String(),
                        airCraft = c.String(),
                        source = c.String(),
                        destination = c.String(),
                        date = c.String(),
                    })
                .PrimaryKey(t => t.PFID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        DateOfBirth = c.String(),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(),
                    })
                .PrimaryKey(t => t.Email);
            
            CreateTable(
                "dbo.UserTokenCaches",
                c => new
                    {
                        UserTokenCacheId = c.Int(nullable: false, identity: true),
                        webUserUniqueId = c.String(),
                        cacheBits = c.Binary(),
                        LastWrite = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserTokenCacheId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserTokenCaches");
            DropTable("dbo.Users");
            DropTable("dbo.PassengerFlights");
            DropTable("dbo.CargoFlights");
        }
    }
}
