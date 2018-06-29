using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetail_0
{
	public partial class MainPage : MasterDetailPage
    {
		public MainPage()
		{
			InitializeComponent();

            // first thing shown is a Detail Page.  Set this page here
            Detail = new NavigationPage(new Page1());

            IsPresented = false;  // present master page?
        }

        private void Button_Clicked1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page1());
            IsPresented = false;  // present master page?

        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page2());
            IsPresented = false;  // present master page?
        }
    }
}
