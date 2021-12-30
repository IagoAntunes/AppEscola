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
    public partial class CadastroEscola : ContentPage
    {
        Picker escolha;
        public CadastroEscola()
        {
            InitializeComponent();
        }
        public List<Escola> escolas = new List<Escola>();
        
        private void CadastrarEscola(Object sender, EventArgs args)
        {
            escolas.Add(new Escola()
            {
                Nome = txtNome.Text.Trim(),
                Cidade = txtCidade.Text.Trim()
            });
            limparCampos();
        }
        private void limparCampos()
        {
            txtNome.Text = string.Empty;
            txtCidade.Text = string.Empty;
        }
        private void ActionPicker(object sender, EventArgs e)
        {
            escolha = (Picker)sender;
        }
        private void MoverNext(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new Tela.Exibir(1,escolas));
            //App.Current.MainPage = new NavigationPage(new Tela.Exibir(1));
        }
        private void GoCadastroProfessores(Object sender,EventArgs args)
        {
            Navigation.PushAsync(new Tela.Cadastro(escolas));
        }
        private void GoCadastroEstudante(Object sender,EventArgs args)
        {
            Navigation.PushAsync(new Tela.CadastroEstudantes(escolas));
        }
    }
}