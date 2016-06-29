using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(template_jqwidgets_mvc5.Startup))]
namespace template_jqwidgets_mvc5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
