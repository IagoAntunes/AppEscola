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
    public partial class CadastroEstudantes : ContentPage
    {
        Picker escolha;
        List<Escola> escolas;
        public CadastroEstudantes(List<Escola> escola)
        {
            InitializeComponent();
            this.escolas = escola;
            //HabilitaBotao();
        }
        private void CadastrarEstudante(Object sender, EventArgs args)
        {
            escolas.Last<Escola>().Estudantes.Add(new Estudante()
            {
                Nome = txtNome.Text,
                idade = txtIdade.Text,
                sexo = escolha.SelectedItem.ToString(),
                ano = txtAno.Text
            });

            limparCampos();
        }
        private void limparCampos()
        {
            txtNome.Text = string.Empty;
            txtIdade.Text = string.Empty;
            txtAno.Text = string.Empty;
        }
        private void MoverNext(Object sender, EventArgs args)
        {
            //App.Current.MainPage = new NavigationPage(new Exibir());
            Navigation.PushAsync(new Tela.Exibir(2,escolas));
            //App.Current.MainPage = new NavigationPage(new Tela.Exibir(2));
        }

        private void ActionPicker(object sender, EventArgs e)
        {
            escolha = (Picker)sender;

        }
        private void HabilitaBotao()
        {
            if(!string.IsNullOrEmpty(txtNome.Text))
            {
                btnCadastrar.IsEnabled = true;
            }
            else
            {
                btnCadastrar.IsEnabled = false;
            }
        }
    }
}