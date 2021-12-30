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
    public partial class Exibir : ContentPage
    {
        private int tipo { get; }
        public Exibir(int tipo)
        {
            this.tipo = tipo;
            InitializeComponent();
            try
            {
                inicializar();
            }catch (Exception ex)
            {
                DisplayAlert("Erro", "Insira os valores", "Ok");
            }
        }
        public int index = 1;
        private void ProximoLista(object sender,EventArgs args)
        {
            if (tipo == 1)
            {
                if (index > Gerenciador.professores.Count - 1)
                {
                    index = 0;
                }
                Professor teste = Gerenciador.professores.ElementAt(index); ;
                lblNome.Text = String.Format($"Nome: {teste.Nome}");
                lblIdade.Text = String.Format($"Idade: {teste.Idade}");
                lbl03.Text = String.Format($"Materia: {teste.Materia}");
                lbl04.Text = String.Format($"Escola: {teste.Escola}");
                index++;
            }
            else if(tipo == 2)
            {
                if (index > Gerenciador.estudantes.Count - 1)
                {
                    index = 0;
                }
                Estudante teste = Gerenciador.estudantes.ElementAt(index); ;
                lblNome.Text = String.Format($"Nome: {teste.Nome}");
                lblIdade.Text = String.Format($"Idade: {teste.idade}");
                lbl03.Text = String.Format($"Sexo: {teste.sexo}");
                lbl04.Text = String.Format($"Ano: {teste.ano}");
                index++;
            }
        }
       
        private void inicializar()
        {
            if (tipo == 1)
            {
                Professor teste = Gerenciador.professores.ElementAt(0);
                lblNome.Text = String.Format($"Nome: {teste.Nome}");
                lblIdade.Text = String.Format($"Idade: {teste.Idade}");
                lbl03.Text = String.Format($"Materia: {teste.Materia}");
                lbl04.Text = String.Format($"Escola: {teste.Escola}");
            }else if(tipo == 2)
            {
                Estudante teste = Gerenciador.estudantes.ElementAt(0);
                lblNome.Text = String.Format($"Nome: {teste.Nome}");
                lblIdade.Text = String.Format($"Idade: {teste.idade}");
                lbl03.Text = String.Format($"Sexo: {teste.sexo}");
                lbl04.Text = String.Format($"Ano: {teste.ano}");
            }
        }
    }
}