using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITI.MVC.Project.Test2.Startup))]
namespace ITI.MVC.Project.Test2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
