using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Win10ToastDemo.ViewModels;

namespace Win10ToastDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
            {
                BootStrapper.DiSetup.DesignMode();
            }
            else
            {
                BootStrapper.DiSetup.App();
                //this is only to load the assembly
                MainViewModel test = new MainViewModel(null);
                test = null;
            }
        }
    }
}
