using NET.efilnukefesin.Extensions.Wpf.Commands;
using NET.efilnukefesin.Implementations.Mvvm.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Win10ToastDemo.Interfaces.Toasts;
using Win10ToastDemo.Models;
using Win10ToastDemo.Models.Factories;

namespace Win10ToastDemo.ViewModels
{
    [Locator("MainPageViewModel")]
    public class MainPageViewModel : BaseViewModel
    {
        #region Properties

        public string SomeText { get; set; } = "HelloWorld";

        public ICommand SendToastCommand { get; set; }

        private IToastService toastService;

        #endregion Properties

        #region Construction

        public MainPageViewModel(IToastService ToastService)
        {
            this.toastService = ToastService;
            this.setupCommands();
        }

        #endregion Construction

        #region Methods

        #region setupCommands
        private void setupCommands()
        {
            this.SendToastCommand = new RelayCommand(this.sendToastCommandExecute, this.sendToastCommandCanExecute);
        }
        #endregion setupCommands

        #region sendToastCommandCanExecute
        private bool sendToastCommandCanExecute()
        {
            return this.toastService.CanSendToasts();
        }
        #endregion sendToastCommandCanExecute

        #region sendToastCommandExecute
        private void sendToastCommandExecute()
        {
            this.toastService.SendToast(ToastBuilder.Create("TestMessage").AddLine("First Line").AddLine("Second Line").AddImage("toastImageAndText.png").Build());
        }
        #endregion sendToastCommandExecute

        #region Initialize
        public override void Initialize()
        {
            //nothing is done here
        }
        #endregion Initialize

        #region dispose
        protected override void dispose()
        {
            //nothing is done here
        }
        #endregion dispose

        #endregion Methods

        #region Events

        #endregion Events
    }
}
