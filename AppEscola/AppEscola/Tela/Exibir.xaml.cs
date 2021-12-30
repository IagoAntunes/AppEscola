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

        List<Escola> Escolas;
        private int tipo { get; }
        public Exibir(int tipo,List<Escola> Escolas)
        {
            this.tipo = tipo;
            InitializeComponent();
            this.Escolas = Escolas;
            inicializar();

        }
        public int index = 1;
        private void ProximoLista(object sender,EventArgs args)
        {
            if (tipo == 1)
            {
                if (index > Escolas.Last<Escola>().professores.Count - 1)
                {
                    index = 0;
                }
                Professor teste = Escolas.Last<Escola>().professores.ElementAt(index); ;
                lblNome.Text = String.Format($"Nome: {teste.Nome}");
                lblIdade.Text = String.Format($"Idade: {teste.Idade}");
                lbl03.Text = String.Format($"Materia: {teste.Materia}");
                index++;
            }
            else if(tipo == 2)
            {
                if (index > Escolas.Last<Escola>().Estudantes.Count - 1)
                {
                    index = 0;
                }
                Estudante teste = Escolas.Last<Escola>().Estudantes.ElementAt(index); ;
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
                Professor teste = Escolas.Last<Escola>().professores.ElementAt(0);
                lblNome.Text = String.Format($"Nome: {teste.Nome}");
                lblIdade.Text = String.Format($"Idade: {teste.Idade}");
                lbl03.Text = String.Format($"Materia: {teste.Materia}");
            }else if(tipo == 2)
            {
                Estudante teste = Escolas.Last<Escola>().Estudantes.ElementAt(0);
                lblNome.Text = String.Format($"Nome: {teste.Nome}");
                lblIdade.Text = String.Format($"Idade: {teste.idade}");
                lbl03.Text = String.Format($"Sexo: {teste.sexo}");
                lbl04.Text = String.Format($"Ano: {teste.ano}");
            }
        }
    }
}