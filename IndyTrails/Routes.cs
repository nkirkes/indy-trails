using System.Web.Routing;
using RestfulRouting;
using IndyTrails.Controllers;

[assembly: WebActivator.PreApplicationStartMethod(typeof(IndyTrails.Routes), "Start")]
namespace IndyTrails
{
    public class Routes : RouteSet
    {
        public override void Map(IMapper map)
        {
            map.DebugRoute("routedebug");
            map.Root<MapController>(x => x.Index());

            /* Accounts */
            map.Resources<AccountController>(account =>
            {
                account.As("account");
                account.Only("index");
                account.Collection(x => x.Get("register"));
                account.Collection(x => x.Post("register"));
                account.Collection(x => x.Get("login"));
                account.Collection(x => x.Post("login"));
                account.Collection(x => x.Get("logout"));
                account.Collection(x => x.Get("changepassword"));
                account.Collection(x => x.Post("changepassword"));
                account.Collection(x => x.Get("changepasswordsuccess"));
                account.Collection(x => x.Get("activate"));
                account.Collection(x => x.Get("resendactivation"));
                account.Collection(x => x.Get("resetpassword"));
                account.Collection(x => x.Post("resetpassword"));
                account.Collection(x => x.Get("manage"));
                account.Collection(x => x.Post("manage"));
                account.Collection(x => x.Post("externallogin"));
            });
        }

        public static void Start()
        {
            var routes = RouteTable.Routes;
            routes.MapRoutes<Routes>();
        }
    }
}