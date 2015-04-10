# Psns.Common.Mvc.Skin [![NuGet Version](http://img.shields.io/nuget/v/Psns.Common.Mvc.Skin.svg?style=flat)](https://www.nuget.org/packages/Psns.Common.Mvc.Skin/) [![NuGet Downloads](http://img.shields.io/nuget/dt/Psns.Common.Mvc.Skin.svg?style=flat)](https://www.nuget.org/packages/Psns.Common.Mvc.Skin/)

## Prerequisites
See [Crudified Prereqs](https://github.com/PSNS-IMF/mvc-crudified/blob/master/README.md).

### Model
* Define a Model class that implements Psns.Common.Mvc.ViewBuilding.Entities.INameable 
	and Psns.Common.Persistence.Definitions.IIdentifiable.
* Decorate the Model's Properties to be displayed on various views by the ViewBuilder
	(i.e. using Psns.Common.Mvc.ViewBuilding.Attributes.ViewDisplayableProperty).
```
public class Product : INameable, IIdentifiable
{
    [ViewDisplayableProperty(DisplayViewTypes.Details)]
    public int Id { get; set; }

    [ViewDisplayableProperty(DisplayViewTypes.Index, DisplayViewTypes.Details)]
    public string Name { get; set; }
}
```
* Implement an Psns.Common.Persistence.Definitions.IRepository for the Model
* Create a **Pluralized** Controller for the Model that inherits from Psns.Common.Mvc.ViewBuilding.Controllers.CrudController.

### Ninject
* If using Ninject, install Ninject.MVC5 and Ninject.Web.WebApi.WebHost.
* Make sure to UPDATE to all of the latest Ninject packages in Nuget Package Manager.  
* In the App_Start/NinjectWebCommon.cs file (RegisterServices method), Load Psns.Common.Persistence.Definitions.DefinitionsNinjectModule 
	and Bind Psns.Common.Mvc.ViewBuilding.ViewBuilders.ICrudViewBuilder to Psns.Common.Mvc.ViewBuilding.ViewBuilders.CrudViewBuilder and 
	Psns.Common.Persistence.Definitions.IRepository<Model> to your implementation.
```
private static void RegisterServices(IKernel kernel)
{
    kernel.Load(new DefinitionsNinjectModule());
    kernel.Bind<ICrudViewBuilder>().To<CrudViewBuilder>();
    kernel.Bind<IRepository<Product>>().To<ProductRepository>();
} 
```

## CI build status
[![Build Status](https://www.myget.org/BuildSource/Badge/psns-common?identifier=b10e826a-952d-4952-94f1-96de0da254a2)](https://www.myget.org/)