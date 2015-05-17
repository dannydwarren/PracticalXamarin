using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using PracticalXamarin.ViewModels;

namespace PracticalXamarin.NativeApps.Android
{
	[Activity( Label = "PracticalXamarin.NativeApps.Android", MainLauncher = true, Icon = "@drawable/icon" )]
	public class MainActivity : Activity
	{
		int count = 1;
		public MessageGeneratorViewModel ViewModel { get; private set; }

		protected override void OnCreate( Bundle bundle )
		{
			base.OnCreate( bundle );

			// Set our view from the "main" layout resource
			SetContentView( Resource.Layout.Main );

			ViewModel = new MessageGeneratorViewModel();

			// Get our button from the layout resource,
			// and attach an event to it
			Button generateMessageButton = FindViewById<Button>( Resource.Id.GenerateMessageButton );
			TextView messageTextView = FindViewById<TextView>( Resource.Id.MessageTextView );
			
			messageTextView.Text = ViewModel.CurrentMessage.Text;

			generateMessageButton.Click += delegate
			{
				ViewModel.GenerateMessage();
				messageTextView.Text = ViewModel.CurrentMessage.Text;
			};
		}

	}
}

