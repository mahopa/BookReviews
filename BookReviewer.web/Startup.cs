using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookReviewer.web.Startup))]
namespace BookReviewer.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
