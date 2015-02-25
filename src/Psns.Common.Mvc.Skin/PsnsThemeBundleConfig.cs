using System.Web;
using System.Web.Optimization;

namespace Psns.Common.Mvc.Skin.Menu
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
            bundles.Add(new StyleBundle("~/css/skinglobal")
                .Include("~/Content/bootstrap/bootstrap-grid.css")
                .Include("~/Content/bootstrap/bootstrap-alert.css")
                .Include("~/Content/PSNSLayout.css"));

            bundles.Add(new StyleBundle("~/css/subheader")
                .Include("~/Content/PSNSLayoutSubHeader.css"));
        }
    }
}