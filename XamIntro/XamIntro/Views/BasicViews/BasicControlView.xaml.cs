using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamIntro.Views.BasicViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BasicControlView : ContentPage
	{
		public BasicControlView ()
		{
			InitializeComponent ();
		}
	}
}