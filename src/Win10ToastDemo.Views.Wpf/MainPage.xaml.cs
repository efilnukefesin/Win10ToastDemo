﻿using NET.efilnukefesin.Implementations.Mvvm.Attributes;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Win10ToastDemo.Views.Wpf
{
    /// <summary>
    /// Interaktionslogik für MainPage.xaml
    /// </summary>
    [ViewModel("MainPageViewModel")]
    [View("MainPage.xaml")]
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
