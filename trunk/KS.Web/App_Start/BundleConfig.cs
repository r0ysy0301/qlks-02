using System.Web;
using System.Web.Optimization;

namespace KS.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/layoutscript").Include(
                "~/Scripts/jquery-1.7.2.js",
                "~/Scripts/images.js",
                "~/Scripts/jquery.placeholder.min.js",
                "~/Scripts/jquery.nivo.slider.js",
                "~/Scripts/portfolio.js",
                "~/Scripts//jquery.prettyPhoto.js",
                "~/Scripts/jquery.tweetscroll.js",
                "~/Scripts/socialstream.jquery.js",
                "~/Scripts/jquery.carouFredSel-6.0.0-packed.js",
                "~/Scripts/include.js",
                "~/Scripts/jquerylayout.js",
                "~/Scripts/caroufredsel.js",
                "~/Scripts/nivo.js",
                "~/Scripts/jquery.mousewheel.js",
                "~/Scripts/tinyscrollbar.js",
                "~/Scripts/custom.js",
                "~/Scripts/isotope.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));
            bundles.Add(new ScriptBundle("~/bundles/ckeditor").Include(
                        "~/ckeditor/ckeditor.js"));

                bundles.Add(new StyleBundle("~/Content/css1").Include(
                "~/Content/css/basic.css",
                "~/Content/css/style.css",
                "~/Content/css/nivo-slider.css",
                "~/Content/css/prettyPhoto.css",
                "~/Content/css/reset.css",
                "~/Content/css/grid.css",
                "~/Content/css/nivo.css",
                "~/Content/css/custom.css",
                "~/Content/style.css",
                "~/Content/Font-Awesome/css/font-awesome.css",
                "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}