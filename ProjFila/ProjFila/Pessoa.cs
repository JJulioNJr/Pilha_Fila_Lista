using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjFila {
    internal class Pessoa {


        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public Pessoa Proximo { get; set; }

        public Pessoa(string Nome, int idade, string telefone) {

            this.Nome = Nome;
            this.Idade = idade;
            this.Telefone = telefone;

            this.Proximo = null;
        }

        public override string ToString() {
            return "\nNome: " + Nome +
                   "\nIdade: " + Idade +
                   "\nTelefone: " + Telefone;
        }
    }
}
