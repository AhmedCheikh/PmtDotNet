namespace Wemtek.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class identityUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CustomUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ClaimType = c.String(unicode: false),
                        ClaimValue = c.String(unicode: false),
                        user_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.user", t => t.user_idUser)
                .Index(t => t.user_idUser);
            
            CreateTable(
                "dbo.CustomUserLogins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoginProvider = c.String(unicode: false),
                        ProviderKey = c.String(unicode: false),
                        UserId = c.Int(nullable: false),
                        user_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.user", t => t.user_idUser)
                .Index(t => t.user_idUser);
            
            CreateTable(
                "dbo.CustomUserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        RoleId = c.Int(nullable: false),
                        user_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.user", t => t.user_idUser)
                .Index(t => t.user_idUser);
            
            AddColumn("dbo.user", "EmailConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.user", "PasswordHash", c => c.String(unicode: false));
            AddColumn("dbo.user", "SecurityStamp", c => c.String(unicode: false));
            AddColumn("dbo.user", "PhoneNumber", c => c.String(unicode: false));
            AddColumn("dbo.user", "PhoneNumberConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.user", "TwoFactorEnabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.user", "LockoutEndDateUtc", c => c.DateTime(precision: 0));
            AddColumn("dbo.user", "LockoutEnabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.user", "AccessFailedCount", c => c.Int(nullable: false));
            AddColumn("dbo.user", "Id", c => c.Int(nullable: false));
            AddColumn("dbo.user", "UserName", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomUserRoles", "user_idUser", "dbo.user");
            DropForeignKey("dbo.CustomUserLogins", "user_idUser", "dbo.user");
            DropForeignKey("dbo.CustomUserClaims", "user_idUser", "dbo.user");
            DropIndex("dbo.CustomUserRoles", new[] { "user_idUser" });
            DropIndex("dbo.CustomUserLogins", new[] { "user_idUser" });
            DropIndex("dbo.CustomUserClaims", new[] { "user_idUser" });
            DropColumn("dbo.user", "UserName");
            DropColumn("dbo.user", "Id");
            DropColumn("dbo.user", "AccessFailedCount");
            DropColumn("dbo.user", "LockoutEnabled");
            DropColumn("dbo.user", "LockoutEndDateUtc");
            DropColumn("dbo.user", "TwoFactorEnabled");
            DropColumn("dbo.user", "PhoneNumberConfirmed");
            DropColumn("dbo.user", "PhoneNumber");
            DropColumn("dbo.user", "SecurityStamp");
            DropColumn("dbo.user", "PasswordHash");
            DropColumn("dbo.user", "EmailConfirmed");
            DropTable("dbo.CustomUserRoles");
            DropTable("dbo.CustomUserLogins");
            DropTable("dbo.CustomUserClaims");
        }
    }
}
