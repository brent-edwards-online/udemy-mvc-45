using System.Web;
using System.Web.Optimization;

namespace ContactWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Assets/js/lib/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Assets/js/lib/bootstrap.min.js"));


            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/Assets/js/lib/dataTables.bootstrap.min.js",
                        "~/Assets/js/lib/dataTables.colRedorder.min.js",
                        "~/Assets/js/lib/jquery.dataTables.min.js"));

            bundles.Add(new StyleBundle("~/asset/css").Include(
                        "~/Assets/css/bootstrap.min.css",
                        "~/Assets/css/jquery.dataTables.min.css",
                        "~/Assets/css/jquery.dataTables_themeroller.css",
                        "~/Assets/css/dataTables.bootstrap.min.css",
                        "~/Assets/css/colReorder.bootstrap.min.css",
                        "~/Assets/css/site.css"));
        }
    }
}
