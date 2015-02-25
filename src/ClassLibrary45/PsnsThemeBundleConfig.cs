using System.Web;
using System.Web.Optimization;

namespace Psns.Common.Mvc.Skin.Mvc
{
    /// <summary>
    /// Contains all script and style bundles required by the Skin
    /// </summary>
    public class PsnsThemeBundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        /// <summary>
        /// Registers all script and style bundles required by the Skin
        /// </summary>
        /// <param name="bundles">The application bundle collection</param>
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            bundles.Add(new ScriptBundle("~/scripts/yui",
                "/static/scripts/yui3/build/yui/yui-min.js")
                .Include("~/Scripts/yui3/build/yui/yui.js"));

            bundles.Add(new ScriptBundle("~/scripts/global")
                .Include("~/Scripts/Shared/YUIConfigurator.js")
                .Include("~/Scripts/Shared/ApplicationMenu.js")
                .Include("~/Scripts/Shared/Alert.js"));

            bundles.Add(new ScriptBundle("~/scripts/respond")
                .Include("~/Scripts/respond.*"));

            bundles.Add(new StyleBundle("~/css/global")
                .Include("~/Content/pure/pure-min.css")
                .Include("~/Content/pure/pure-skin-psns.css")
                .Include("~/Content/bootstrap/bootstrap-grid.css")
                .Include("~/Content/bootstrap/bootstrap-alert.css")
                .Include("~/Content/PSNSLayout.css"));

            bundles.Add(new StyleBundle("~/css/subheader")
                .Include("~/Content/PSNSLayoutSubHeader.css"));
        }
    }
}