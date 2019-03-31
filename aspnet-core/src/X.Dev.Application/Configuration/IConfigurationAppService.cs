using System.Threading.Tasks;
using X.Dev.Configuration.Dto;

namespace X.Dev.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
