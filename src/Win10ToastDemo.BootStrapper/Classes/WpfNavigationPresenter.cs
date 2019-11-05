using NET.efilnukefesin.Contracts.Logger;
using NET.efilnukefesin.Implementations.Mvvm.WPF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Win10ToastDemo.BootStrapper.Classes
{
    public class WpfNavigationPresenter : BaseWpfNavigationPresenter
    {
        #region Construction

        public WpfNavigationPresenter(ILogger Logger)
            : base("pack://application:,,,/Win10ToastDemo.Views.Wpf;component/", "Win10ToastDemo.Views.", Logger)
        {

        }
        #endregion Construction
    }
}
