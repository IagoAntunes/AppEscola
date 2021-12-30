using AppEscola.Modelos;
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
    public partial class Cadastro : ContentPage
    {
        Picker escolha;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void CadastrarProfessor(Object sender, EventArgs args)
        {
            Gerenciador.professores.Add(new Professor()
            {
                Nome = txtNome.Text.Trim(),
                Idade = txtIdade.Text.Trim(),
                Escola = txtEscola.Text.Trim(),
                Materia = escolha.SelectedItem.ToString(),
            });

            limparCampos();
        }
        private void limparCampos()
        {
            txtNome.Text = string.Empty;
            txtIdade.Text = string.Empty;
            txtEscola.Text = string.Empty;
        }
        private void ActionPicker(object sender, EventArgs e)
        {
            escolha = (Picker)sender;

        }
        private void MoverNext(Object sender, EventArgs args)
        {
            //App.Current.MainPage = new NavigationPage(new Exibir());
            Navigation.PushAsync(new Tela.Exibir(1));
            //App.Current.MainPage = new NavigationPage(new Tela.Exibir(1));
        }
    }
}