using System;
using System.Collections.Generic;
using System.Text;
using Win10ToastDemo.Interfaces.Toasts;
using Windows.UI.Notifications;
using Windows.Data.Xml.Dom;
using Win10ToastDemo.Models;
using System.IO;

namespace Win10ToastDemo.Services.Toasts
{
    public class Win10ToastService : IToastService
    {
        #region Properties

        private const string APP_ID = "SomeId";  //TODO: move id to configuration service, be sure to specify the AppUserModelId on your application's shortcut!

        #endregion Properties

        #region Construction

        #endregion Construction

        #region Methods

        #region CanSendToasts
        public bool CanSendToasts()
        {
            bool result = true;
            //TODO: make checks, if Win10 etc.
            return result;
        }
        #endregion CanSendToasts

        #region SendToast
        public void SendToast(Toast toast)
        {
            // Get a toast XML template
            XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText04);

            // Fill in the text elements
            XmlNodeList stringElements = toastXml.GetElementsByTagName("text");
            for (int i = 0; i < stringElements.Length; i++)
            {
                // in the layout, we are using, we have three lines: one for the caption and two others
                if (i.Equals(0))
                {
                    stringElements[i].AppendChild(toastXml.CreateTextNode(toast.Caption));
                }
                else if (toast.Lines != null && toast.Lines.Count > 0 && i - 1 <= toast.Lines.Count)
                {
                    stringElements[i].AppendChild(toastXml.CreateTextNode(toast.Lines[i - 1]));
                }
            }

            // Specify the absolute path to an image
            String imagePath = "file:///" + Path.GetFullPath(toast.ImageFilename);
            XmlNodeList imageElements = toastXml.GetElementsByTagName("image");
            imageElements[0].Attributes.GetNamedItem("src").NodeValue = imagePath;

            // Create the toast and attach event listeners
            ToastNotification toastNotification = new ToastNotification(toastXml);
            toastNotification.Activated += this.toastActivated;
            toastNotification.Dismissed += this.toastDismissed;
            toastNotification.Failed += this.toastFailed;
            toastNotification.RemoteId = toast.Id.ToString();  //for identifying the source later on
            toastNotification.ExpirationTime = toast.ExpirationTime;

            // Show the toast. Be sure to specify the AppUserModelId on your application's shortcut!
            ToastNotificationManager.CreateToastNotifier(Win10ToastService.APP_ID).Show(toastNotification);
        }
        #endregion SendToast

        #region toastActivated
        private void toastActivated(ToastNotification sender, object e)
        {
            //TODO: how to react to events? Toast dismissed, clicked etc? Handled in this service or the specific toast?
            //Dispatcher.Invoke(() =>
            //{
            //    Activate();
            //    Output.Text = "The user activated the toast.";
            //});
        }
        #endregion toastActivated

        #region toastDismissed
        private void toastDismissed(ToastNotification sender, ToastDismissedEventArgs e)
        {
            //TODO: how to react to events? Toast dismissed, clicked etc? Handled in this service or the specific toast?
            String outputText = "";
            switch (e.Reason)
            {
                case ToastDismissalReason.ApplicationHidden:
                    outputText = "The app hid the toast using ToastNotifier.Hide";
                    break;
                case ToastDismissalReason.UserCanceled:
                    outputText = "The user dismissed the toast";
                    break;
                case ToastDismissalReason.TimedOut:
                    outputText = "The toast has timed out";
                    break;
            }

            //Dispatcher.Invoke(() =>
            //{
            //    Output.Text = outputText;
            //});
        }
        #endregion toastDismissed

        #region toastFailed
        private void toastFailed(ToastNotification sender, ToastFailedEventArgs e)
        {
            //TODO: how to react to events? Toast dismissed, clicked etc? Handled in this service or the specific toast?
            //Dispatcher.Invoke(() =>
            //{
            //    Output.Text = "The toast encountered an error.";
            //});
        }
        #endregion toastFailed

        #endregion Methods

        #region Events

        #endregion Events
    }
}
