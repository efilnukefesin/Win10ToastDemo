using NET.efilnukefesin.Contracts.Mvvm;
using NET.efilnukefesin.Implementations.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Win10ToastDemo.Views.Wpf
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DiManager.GetInstance().Resolve<INavigationPresenter>().RegisterPresenter(this.mainFrame);  //must be done initially to register the frame in which the pages are to be shown
        }
    }
}
