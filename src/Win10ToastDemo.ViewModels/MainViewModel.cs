using NET.efilnukefesin.Contracts.Mvvm;
using NET.efilnukefesin.Implementations.Mvvm.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Win10ToastDemo.ViewModels
{
    /// <summary>
    /// implementation of the ViewModel for the view MainWindow (reference comes from the view)
    /// </summary>
    [Locator("MainViewModel")]
    public class MainViewModel : BaseViewModel
    {
        #region Properties

        private INavigationService navigationService;

        #endregion Properties

        #region Construction

        public MainViewModel(INavigationService NavigationService)
        {
            this.navigationService = NavigationService;
        }

        #endregion Construction

        #region Methods

        #region Initialize
        public override void Initialize()
        {
            if (this.navigationService != null)
            {
                bool hasNavigatedSuccessfully = this.navigationService.Navigate("MainPageViewModel");
            }
        }
        #endregion Initialize

        #region dispose
        protected override void dispose()
        {
            

        }
        #endregion dispose

        #endregion Methods

        #region Events

        #endregion Events
    }
}
