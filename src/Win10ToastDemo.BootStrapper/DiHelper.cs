﻿using NET.efilnukefesin.Contracts.DependencyInjection.Enums;
using NET.efilnukefesin.Implementations.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Win10ToastDemo.BootStrapper
{
    /// <summary>
    /// helper class to avoid direct calls to DiManager class
    /// </summary>
    public static class DiHelper
    {
        #region Methods

        #region GetService: gets a service implementation from the DI Container
        /// <summary>
        /// gets a service implementation from the DI Container
        /// </summary>
        /// <typeparam name="I">the interface you need the implementation for</typeparam>
        /// <returns>the service implementation</returns>
        public static I GetService<I>()
        {
            return DiManager.GetInstance().Resolve<I>();
        }
        #endregion GetService

        #region GetService: gets a service implementation from the DI Container
        /// <summary>
        /// gets a service implementation from the DI Container
        /// </summary>
        /// <typeparam name="I">the interface you need the implementation for</typeparam>
        /// <param name="Parameters">C'tor Params</param>
        /// <returns>the service implementation</returns>
        public static I GetService<I>(params object[] Parameters)
        {
            return DiManager.GetInstance().Resolve<I>(Parameters);
        }
        #endregion GetService

        #region Register
        public static void Register<TFrom, TTo>(Lifetime Lifetime = Lifetime.NewInstanceEveryTime) where TFrom : class where TTo : class, TFrom
        {
            DiManager.GetInstance().RegisterType<TFrom, TTo>(Lifetime);
        }
        #endregion Register

        #endregion Methods
    }
}
