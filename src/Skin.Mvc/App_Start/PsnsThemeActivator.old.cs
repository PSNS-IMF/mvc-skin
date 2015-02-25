[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Psns.Common.Mvc.Skin.App_Start.PsnsThemeActivator), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Psns.Common.Mvc.Skin.App_Start.PsnsThemeActivator), "Stop")]

namespace Psns.Common.Mvc.Skin.App_Start
{
    using System.Web.Optimization;
    using System.Web.WebPages.Razor;

    using Psns.Common.Mvc.Skin.Mvc;

    public static class PsnsThemeActivator 
    {
        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            PsnsThemeBundleConfig.RegisterBundles(BundleTable.Bundles);
            WebCodeRazorHost.AddGlobalImport("System.Web.Optimization");
            WebCodeRazorHost.AddGlobalImport("Psns.Common.Mvc.Skin.Menu");
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {

        }    
    }
}
