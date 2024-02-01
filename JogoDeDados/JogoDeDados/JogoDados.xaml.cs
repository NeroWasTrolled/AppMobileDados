using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JogoDeDados
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JogoDados : ContentPage
    {
        public JogoDados()
        {
            InitializeComponent();
            Random r = new Random();
            int n = r.Next(1, 6);
            if (n == 1)
            {
                dados.Source = "um";
            }
            if (n == 2)
            {
                dados.Source = "dois";
            }
            if (n == 3)
            {
                dados.Source = "tres";
            }
            if (n == 4)
            {
                dados.Source = "quatro";
            }
            if (n == 5)
            {
                dados.Source = "cinco";
            }
            if (n == 6)
            {
                dados.Source = "seis";
            }
        }

        private async void btVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
    
}