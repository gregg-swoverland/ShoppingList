using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShoppingList.Startup))]
namespace MyShoppingList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
