﻿using System;
using System.Collections.Generic;
using System.Text;
using Win10ToastDemo.Models;

namespace Win10ToastDemo.Interfaces.Toasts
{
    public interface IToastService
    {
        #region Properties

        #endregion Properties

        #region Methods

        /// <summary>
        /// determines, whether toasts can be sent or not
        /// </summary>
        bool CanSendToasts();

        void SendToast(Toast toast);

        //TODO: how to react to events? Toast dismissed, clicked etc? Handled in this service or the specific toast?

        #endregion Methods

        #region Events

        #endregion Events
    }
}