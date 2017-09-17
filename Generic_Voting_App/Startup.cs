using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Generic_Voting_App.Startup))]
namespace Generic_Voting_App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
