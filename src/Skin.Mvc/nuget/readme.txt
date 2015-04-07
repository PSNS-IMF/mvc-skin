* Define a Model class that implements Psns.Common.Mvc.ViewBuilding.Entities.INameable 
	and Psns.Common.Persistence.Definitions.IIdentifiable.

* Decorate the Model's Properties to be displayed on various views by the ViewBuilder
	(i.e. using Psns.Common.Mvc.ViewBuilding.Attributes.ViewDisplayableProperty).

* Implement an Psns.Common.Persistence.Definitions.IRepository for the Model.

* Create a Controller for the Model that inherits from Psns.Common.Mvc.ViewBuilding.Controllers.CrudController.

* If using Ninject, install Ninject.MVC5 and Ninject.Web.WebApi.WebHost, and then make sure to UPDATE to all of the latest
	Ninject packages in Nuget Package Manager.  In the App_Start/NinjectWebCommon.cs file 
	(RegisterServices method), Load Psns.Common.Persistence.Definitions.DefinitionsNinjectModule and Bind
	Psns.Common.Mvc.ViewBuilding.ViewBuilders.ICrudViewBuilder to Psns.Common.Mvc.ViewBuilding.ViewBuilders.CrudViewBuilder and
	Psns.Common.Persistence.Definitions.IRepository<Model> to your implementation.