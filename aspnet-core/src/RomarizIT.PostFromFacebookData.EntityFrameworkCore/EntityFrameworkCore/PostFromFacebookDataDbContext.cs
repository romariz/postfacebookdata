using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RomarizIT.PostFromFacebookData.Authorization.Roles;
using RomarizIT.PostFromFacebookData.Authorization.Users;
using RomarizIT.PostFromFacebookData.MultiTenancy;

namespace RomarizIT.PostFromFacebookData.EntityFrameworkCore
{
    public class PostFromFacebookDataDbContext : AbpZeroDbContext<Tenant, Role, User, PostFromFacebookDataDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Services.Service> Services { get; set; }
        public PostFromFacebookDataDbContext(DbContextOptions<PostFromFacebookDataDbContext> options)
            : base(options)
        {
        }
    }
}
