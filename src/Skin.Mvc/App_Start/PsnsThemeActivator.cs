[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Psns.Common.Mvc.Skin.View.App_Start.PsnsThemeActivator), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Psns.Common.Mvc.Skin.View.App_Start.PsnsThemeActivator), "Stop")]

namespace Psns.Common.Mvc.Skin.View.App_Start
{
    using System.Web.Optimization;

    using Psns.Common.Mvc.Skin.Menu;

    public static class PsnsThemeActivator
    {
        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            PsnsThemeBundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {

        }
    }
}
