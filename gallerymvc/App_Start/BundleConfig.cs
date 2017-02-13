using System.Web;
using System.Web.Optimization;

namespace gallerymvc
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/blueimp").Include(
                "~/Scripts/blueimp-helper.js",
                "~/Scripts/blueimp-gallery.js",
                "~/Scripts/blueimp-gallery-fullscreen.js",
                "~/Scripts/blueimp-gallery-indicator.js",
                "~/Scripts/blueimp-gallery-video.js",
                "~/Scripts/blueimp-gallery-vimeo.js",
                "~/Scripts/blueimp-gallery-youtube.js",
                "~/Scripts/vendor/jquery.js",
                "~/Scripts/jquery.blueimp-gallery.js",
                "~/Scripts/gallerysetup.js"
                ));

            bundles.Add(new StyleBundle("~/Content/blueimp").Include(
                "~/Content/blueimp-gallery.css",
                "~/Content/blueimp-gallery-indicator.css",
                "~/Content/blueimp-gallery-video.css"
                ));
        }
    }
}
