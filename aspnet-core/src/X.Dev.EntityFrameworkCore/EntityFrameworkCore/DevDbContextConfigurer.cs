using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace X.Dev.EntityFrameworkCore
{
    public static class DevDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DevDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DevDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
