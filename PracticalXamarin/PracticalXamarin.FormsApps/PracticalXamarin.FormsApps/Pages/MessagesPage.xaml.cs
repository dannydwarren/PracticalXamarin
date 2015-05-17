using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticalXamarin.ViewModels;
using Xamarin.Forms;

namespace PracticalXamarin.FormsApps.Pages
{
	public partial class MessagesPage : ContentPage
	{
		public MessagesPage()
		{
			InitializeComponent();

			ViewModel = new MessageGeneratorViewModel();
			BindingContext = ViewModel;
		}

		public MessageGeneratorViewModel ViewModel { get; private set; }

		public void GenerateMessageButtonClicked( object sender, EventArgs e )
		{
			ViewModel.GenerateMessage();
		}
	}
}
