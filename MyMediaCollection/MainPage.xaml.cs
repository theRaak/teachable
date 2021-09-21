﻿using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using MyMediaCollection.ViewModels;
using Windows.UI.Popups;

namespace MyMediaCollection
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public MainViewModel ViewModel => App.ViewModel;
    }
}