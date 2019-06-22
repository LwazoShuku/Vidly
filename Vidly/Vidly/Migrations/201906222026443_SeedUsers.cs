namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3771bcbb-2cab-4be6-994b-7a3fa1ee6333', N'guest@vidly.com', 0, N'AD63TYFvis0mvtUnZWBQWigRaKpNTL2fxo1WmEppkvpe1JyMz+Z7UuGZxMMKvZZS7g==', N'0c358501-34c2-482a-99f5-1274139c7bed', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c89105f3-6c19-4ad7-a21f-163727951daa', N'admin@vidly.com', 0, N'AOitZ8VbOFMXkPiSOPX694uiWaszWpzK4Te2b/V/AaL3hKeY2kf/X5+1HRRn4g845g==', N'a5459278-58cd-4a59-ba35-8e7dccbd01c2', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'057043f5-8f0e-42b6-8ab6-2d577675857f', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c89105f3-6c19-4ad7-a21f-163727951daa', N'057043f5-8f0e-42b6-8ab6-2d577675857f')

");
        }
        
        public override void Down()
        {
        }
    }
}
