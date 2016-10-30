namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2bc02606-1125-487d-9255-ee4996bb19b3', N'admin@vidly.com', 0, N'AGu7a5gtdG4+wIEes65nOdiRBvs932OYYvU4UsTL/YncfOg3zfdBDShNk9YeK4AgrA==', N'837f5189-e1c2-4790-804a-a33335b97131', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'74c282fd-8924-4759-9e00-08af84b29e08', N'gust@vidly.com', 0, N'AM7FqNRKyfBS2iMJg1hSm4nvYG7ixGPPnbKNf6QqQo45ee2JyTZMjLcPHEZW9RrVHA==', N'5641b429-ef94-4e0f-a0f4-3d3cb1dd63ad', NULL, 0, 0, NULL, 1, 0, N'gust@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bcb6a31c-12fc-4fa1-80d2-5603d4b90b3b', N'alexprift@yahoo.gr', 0, N'ACFpPrJY0oxXmW+VzPsMHGrxMFpyuURt6yR04tapqx/pJfCnAL7kuPx/d8byOk9TUQ==', N'af31852d-ef62-4036-ae26-88c130cfd2bc', NULL, 0, 0, NULL, 1, 0, N'alexprift@yahoo.gr')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a2d9ff03-6c53-40a3-993f-875758c5dd33', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2bc02606-1125-487d-9255-ee4996bb19b3', N'a2d9ff03-6c53-40a3-993f-875758c5dd33')

");
        }
        
        public override void Down()
        {
        }
    }
}
