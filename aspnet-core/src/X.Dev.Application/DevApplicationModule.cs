using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using X.Dev.Authorization;

namespace X.Dev
{
    [DependsOn(
        typeof(DevCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DevApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DevAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DevApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
