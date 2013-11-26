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
        }

        public static void Start()
        {
            var routes = RouteTable.Routes;
            routes.MapRoutes<Routes>();
        }
    }
}