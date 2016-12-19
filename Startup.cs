using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultiLangDemo.Startup))]
namespace MultiLangDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
