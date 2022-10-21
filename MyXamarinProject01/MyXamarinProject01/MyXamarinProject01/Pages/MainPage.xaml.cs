using MyXamarinProject01.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyXamarinProject01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void BtnIniciar_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new MenuPage());
            Application.Current.MainPage = new FrmPrincipal();

        }

        private void BtnRegistrar_Clicked(object sender, EventArgs e)
        {
           Navigation.PushAsync(new RegistroPage());
        }
    }
}
