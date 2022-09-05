using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLista {
    internal class Aluno {

        public int Ra { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public String Curso { get; set; }

        public Aluno Proximo { get; set; }

        public Aluno(int Ra, string Nome, int Idade,string Curso) {

            this.Ra = Ra;
            this.Nome = Nome;
            this.Idade = Idade;
            this.Curso = Curso;
            this.Proximo = null;
        }

        public override string ToString() {
            return "\n\t\t\t*** Dados do aluno ***\n" +
                   "\n\t\t\tRa: " + Ra +
                   "\n\t\t\tNome: " + Nome +
                   "\n\t\t\tIdade:" + Idade +
                   "\n\t\t\tCurso: " + Curso;
        }
    }
}
