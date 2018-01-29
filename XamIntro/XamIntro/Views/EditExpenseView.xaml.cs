using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamIntro.ViewModels;

namespace XamIntro.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditExpenseView : ContentPage
	{
		public EditExpenseView ()
		{
			InitializeComponent ();
            this.BindingContext = new EditExpenseViewModel();
        }
	}
}