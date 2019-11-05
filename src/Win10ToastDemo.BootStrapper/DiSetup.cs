using NET.efilnukefesin.Contracts.DependencyInjection.Enums;
using NET.efilnukefesin.Contracts.Logger;
using NET.efilnukefesin.Contracts.Mvvm;
using NET.efilnukefesin.Implementations.DependencyInjection;
using NET.efilnukefesin.Implementations.Logger.SerilogLogger;
using NET.efilnukefesin.Implementations.Mvvm;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Win10ToastDemo.BootStrapper.Classes;
using Win10ToastDemo.Interfaces.Toasts;
using Win10ToastDemo.Services.Toasts;

namespace Win10ToastDemo.BootStrapper
{
    public static class DiSetup
    {
        #region Methods

        #region App
        public static void App()
        {
            DiSetup.@base();
        }
        #endregion App

        #region DesignMode
        public static void DesignMode()
        {
            DiSetup.@base();
        }
        #endregion DesignMode

        #region base
        private static void @base(bool isInMemory = false, HttpMessageHandler overrideHttpMessageHandler = null)
        {
            DiManager.GetInstance().RegisterType<IToastService, Win10ToastService>(Lifetime.Singleton);

            DiManager.GetInstance().RegisterType<ILogger, SerilogLogger>(Lifetime.Singleton);
            DiManager.GetInstance().RegisterType<INavigationPresenter, WpfNavigationPresenter>(Lifetime.Singleton);
            DiManager.GetInstance().RegisterType<IViewModelLocator, ViewModelLocator>(Lifetime.Singleton);
            DiManager.GetInstance().RegisterType<INavigationService, NavigationService>(Lifetime.Singleton);
        }
        #endregion base

        #endregion Methods
    }
}
