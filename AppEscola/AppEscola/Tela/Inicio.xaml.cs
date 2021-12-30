using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppEscola.Tela
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private async void GoCadastroProfessores(object sender,EventArgs args)
        {
            //App.Current.MainPage = new NavigationPage(new Tela.Cadastro());
            await Navigation.PushAsync(new Tela.Cadastro());
        }
        private async void GoCadastroEstudantes(object sender,EventArgs args)
        {
            //App.Current.MainPage = new NavigationPage(new Tela.CadastroEstudantes());
            await Navigation.PushAsync(new Tela.CadastroEstudantes());
        }
    }
}