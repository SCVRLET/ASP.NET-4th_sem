using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using RepusBlog_businessLayer.Services;
using Microsoft.AspNet.Identity;
using RepusBlog_businessLayer.Interfaces;

[assembly: OwinStartup(typeof(RepusBlog_presentationLayer.App_Start.Startup))]

namespace RepusBlog_presentationLayer.App_Start
{
    public class Startup
    {
        IServiceCreator serviceCreator = new ServiceCreator();
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext<IUserService>(CreateUserService);
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login"),
            });
        }

        private IUserService CreateUserService()
        {
            return serviceCreator.CreateUserService("DefaultConnection");
        }
    }
}
