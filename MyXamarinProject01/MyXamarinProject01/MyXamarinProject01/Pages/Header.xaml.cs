using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyXamarinProject01.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Header : ContentPage
    {
        public Header()
        {
            InitializeComponent();
        }

        private void ToolbarRegistrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page());
        }
    }
}