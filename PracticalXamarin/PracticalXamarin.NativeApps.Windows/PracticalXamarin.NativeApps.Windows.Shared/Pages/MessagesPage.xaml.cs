﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using PracticalXamarin.ViewModels;

namespace PracticalXamarin.NativeApps.Windows.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MessagesPage : Page
    {
        public MessagesPage()
        {
            this.InitializeComponent();

	        ViewModel = new MessageGeneratorViewModel();
	        DataContext = ViewModel;
        }

	    public MessageGeneratorViewModel ViewModel { get; private set; }


	    private void GenerateMessageButtonClick(object sender, RoutedEventArgs e)
	    {
		    ViewModel.GenerateMessage();
	    }
    }
}
