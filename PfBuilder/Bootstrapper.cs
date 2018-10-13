using Microsoft.Practices.Unity;
using PfBuilder.View;
using Prism.Unity;
using System.Windows;

namespace PfBuilder
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
