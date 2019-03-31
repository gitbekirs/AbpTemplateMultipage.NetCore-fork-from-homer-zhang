using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using X.Dev.Authorization.Roles;
using X.Dev.Authorization.Users;
using X.Dev.MultiTenancy;

namespace X.Dev.EntityFrameworkCore
{
    public class DevDbContext : AbpZeroDbContext<Tenant, Role, User, DevDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DevDbContext(DbContextOptions<DevDbContext> options)
            : base(options)
        {
        }
    }
}
