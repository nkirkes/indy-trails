using System.Web;
using System.Web.Optimization;

namespace IndyTrails
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/public/js/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/public/js/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/public/js/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/public/js/bootstrap.js",
                      "~/public/js/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/leaflet").Include(
                      "~/public/js/leaflet.js", 
                      "~/public/js/L.Control.Locate.js",
                      "~/public/js/map.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/public/css/bootstrap.css",
                      "~/public/css/site.css",
                      "~/public/css/leaflet.css",
                      "~/public/css/L.Control.Locate.css",
                      "~/public/css/map.css"));
        }
    }
}
