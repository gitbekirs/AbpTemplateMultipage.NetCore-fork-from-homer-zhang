using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using X.Dev.Configuration;
using X.Dev.Web;

namespace X.Dev.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class DevDbContextFactory : IDesignTimeDbContextFactory<DevDbContext>
    {
        public DevDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DevDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DevDbContextConfigurer.Configure(builder, configuration.GetConnectionString(DevConsts.ConnectionStringName));

            return new DevDbContext(builder.Options);
        }
    }
}
