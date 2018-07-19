using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsPageDemo.Startup))]
namespace WebFormsPageDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
