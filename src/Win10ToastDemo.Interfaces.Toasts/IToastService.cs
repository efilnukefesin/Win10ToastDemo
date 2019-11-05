using System;
using System.Collections.Generic;
using System.Text;
using Win10ToastDemo.Models;

namespace Win10ToastDemo.Interfaces.Toasts
{
    public interface IToastService
    {
        #region Methods

        #region CanSendToasts: determines, whether toasts can be sent or not
        /// <summary>
        /// determines, whether toasts can be sent or not
        /// </summary>
        /// <returns>true, if the toast can be sent</returns>
        bool CanSendToasts();
        #endregion CanSendToasts

        #region SendToast: sends a toast
        /// <summary>
        /// sends a toast
        /// </summary>
        /// <param name="toast">the toast to send</param>
        void SendToast(Toast toast);
        #endregion SendToast

        #endregion Methods

        #region Events

        #endregion Events
    }
}
