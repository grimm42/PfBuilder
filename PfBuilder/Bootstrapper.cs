using Microsoft.Practices.Unity;
using PfBuilder.CharacterCreator;
using PfBuilder.Infrastructure.Services;
using PfBuilder.Views;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Unity;
using System;
using System.Globalization;
using System.Reflection;
using System.Windows;

namespace PfBuilder
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            var catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(CharacterCreatorModule));
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver((viewType) =>
            {
                var viewName = viewType.FullName;
                var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                var viewModelName = String.Format(CultureInfo.InvariantCulture, "{0}ViewModel, {1}", viewName, viewAssemblyName);
                return Type.GetType(viewModelName);
            });
            ViewModelLocationProvider.SetDefaultViewModelFactory((type) => Container.Resolve(type));

            Container.RegisterType<IDialogService, DialogService>(new ContainerControlledLifetimeManager());
        }
    }
}