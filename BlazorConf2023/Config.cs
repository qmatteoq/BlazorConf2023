using Microsoft.TeamsFx.Configuration;

namespace BlazorConf2023
{
    public class ConfigOptions
    {
        public TeamsFxOptions TeamsFx { get; set; }
    }
    public class TeamsFxOptions
    {
        public AuthenticationOptions Authentication { get; set; }
    }
}
