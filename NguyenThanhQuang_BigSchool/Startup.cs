using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenThanhQuang_BigSchool.Startup))]
namespace NguyenThanhQuang_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
