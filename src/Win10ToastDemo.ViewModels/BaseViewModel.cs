using NET.efilnukefesin.Contracts.Mvvm;
using NET.efilnukefesin.Implementations.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Win10ToastDemo.ViewModels
{
    /// <summary>
    /// base ViewModel implementation, supporting INotifyPropertyChanged
    /// </summary>
    public abstract class BaseViewModel : BaseObject, IViewModel
    {
        #region Properties

        protected BaseViewModel Parent { get; set; }

        #endregion Properties

        #region Construction

        public BaseViewModel(BaseViewModel Parent = null)
        {
            this.Parent = Parent;
        }

        #endregion Construction

        #region Methods

        #region Initialize: Initialize Method, is being called after the discovery and instanciation of all viewmodels
        /// <summary>
        /// Initialize Method, is being called after the discovery and instanciation of all viewmodels
        /// </summary>
        public abstract void Initialize();
        #endregion Initialize

        #region NotifyPropertyChanged
        public void NotifyPropertyChanged()
        {
            this.PropertyChanged(this, new PropertyChangedEventArgs(String.Empty));
        }
        #endregion NotifyPropertyChanged

        #endregion Methods

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events
    }
}
