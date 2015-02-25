[assembly: WebActivatorEx.PreApplicationStartMethod(typeof($rootnamespace$.App_Start.PsnsThemeActivator), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof($rootnamespace$.App_Start.PsnsThemeActivator), "Stop")]

namespace $rootnamespace$.App_Start
{
    using System.Web.Optimization;

	using Psns.Common.Mvc.Skin.Menu;
	using Psns.Common.Mvc.ViewBuilding.Menu;

    public static class PsnsThemeActivator 
    {
        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            PsnsThemeBundleConfig.RegisterBundles(BundleTable.Bundles);
			GlobalMenu.GlobalMenuItems.Add(new AppsMenuItem());
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {

        }    
    }
}
