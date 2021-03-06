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
        List<Escola> escolas;
        List<String> nomesEscolas = new List<String>();
        public Cadastro(List<Escola> escolas)
        {
            InitializeComponent();
            this.escolas = escolas;

            ListaNomesEscolas(escolas);
            pickEscolas.ItemsSource = nomesEscolas;
        }

        private void CadastrarProfessor(Object sender, EventArgs args)
        {
            escolas.Last<Escola>().professores.Add(new Professor()
            {
                Nome = txtNome.Text.Trim(),
                Idade = txtIdade.Text.Trim(),
                Materia = escolha.SelectedItem.ToString()
            });

            limparCampos();
        }
        private void limparCampos()
        {
            txtNome.Text = string.Empty;
            txtIdade.Text = string.Empty;
        }
        private void ActionPicker(object sender, EventArgs e)
        {
            escolha = (Picker)sender;
        }
        private void MoverNext(Object sender, EventArgs args)
        {
            //App.Current.MainPage = new NavigationPage(new Exibir());
            Navigation.PushAsync(new Tela.Exibir(1,escolas));
            //App.Current.MainPage = new NavigationPage(new Tela.Exibir(1));
        }
        private void ListaNomesEscolas(List<Escola> escolas)
        {
            foreach (var escola in escolas)
            {
                nomesEscolas.Add(escola.Nome);
            }
        }
    }
}