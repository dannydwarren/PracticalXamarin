using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using PracticalXamarin.Models;

namespace PracticalXamarin.ViewModels
{
	public class MessageGeneratorViewModel : INotifyPropertyChanged
	{
		public MessageGeneratorViewModel()
		{
			CurrentMessage = new GeneratedMessage("Default Message");
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private GeneratedMessage _currentMessage;
		public GeneratedMessage CurrentMessage
		{
			[DebuggerStepThrough]
			get { return _currentMessage; }
			set
			{
				if ( Equals( value, _currentMessage ) )
					return;

				_currentMessage = value;
				NotifyPropertyChanged();
			}
		}

		public void GenerateMessage()
		{
			CurrentMessage = new GeneratedMessage( "Generated: " + DateTime.Now );
		}

		protected virtual void NotifyPropertyChanged( [CallerMemberName] string propertyName = null )
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if ( handler != null ) handler( this, new PropertyChangedEventArgs( propertyName ) );
		}
	}
}
