using System;
using System.Collections.Generic;
using System.Text;

namespace AppEscola.Modelos
{
    public class Escola
    {
        public List<Estudante> Estudantes = new List<Estudante>();
        public List<Professor> professores = new List<Professor>();

        public string Nome { get; set; }
        public string Cidade { get; set; }
    }
}
