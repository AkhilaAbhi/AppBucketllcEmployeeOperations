using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppBucketllcEmployeeOperations.Startup))]
namespace AppBucketllcEmployeeOperations
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
