using Libs;
using Owin;

namespace WebApp
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use((context, next) =>
            {
                return context.Response.WriteAsync($"{Constants.Feature1}<br/>{Constants.Feature2}<br/>{Constants.Feature3}<br/>{Constants.Feature5}");
            });
        }
    }
}