using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CodePulse_API.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
            


        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "063a543d-7433-4af6-bd08-39acd13cc70e";
            var writerRoleId = "08d9af74-1992-4e5b-80fe-7234f04086ed";

            //Create Reader amd Writer Role
            var roles = new List<IdentityRole>
            {
                new IdentityRole()
                {
                    Id=readerRoleId,
                    Name="Reader",
                    NormalizedName="Reader".ToUpper(),
                    ConcurrencyStamp=readerRoleId
                },
                new IdentityRole()
                {
                    Id= writerRoleId,
                    Name= "Writer",
                    NormalizedName="Writer".ToUpper(),
                    ConcurrencyStamp=writerRoleId
                }
            };

            //Seed the roles
            builder.Entity<IdentityRole>().HasData(roles);



            //Create an Admin User
            var adminUserId = "dfb53c3a-1caf-4165-a4d4-92f615c1cb88";


            var admin = new IdentityUser()
            {
                Id = adminUserId,
                UserName = "admin@codepulse.com",
                Email = "admin@codepulse.com",
                NormalizedEmail = "admin@codepulse.com".ToUpper(),
                NormalizedUserName = "admin@codepulse.com".ToUpper()

            };
            admin.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(admin, "Admin@123");
           
            builder.Entity<IdentityUser>().HasData(admin);

            //Gives Roles To Admin
            var adminRoles = new List<IdentityUserRole<string>>()
            {
                new ()
                {
                    UserId = adminUserId,
                    RoleId = readerRoleId
                },

                new()
                {
                    UserId = adminUserId,
                    RoleId = writerRoleId

                }
            };

            builder.Entity<IdentityUserRole<string>>().HasData(adminRoles);






        }


    }
}
