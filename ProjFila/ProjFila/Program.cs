using System;

namespace ProjFila {
    internal class Program {
        static void Main(string[] args) {
          
          FilaPessoas  contatos = new FilaPessoas();

            contatos.Push(new Pessoa("MORANGAO", 32, "1990"));
            contatos.Push(new Pessoa("XB", 25, "1990"));
            contatos.Imprimir();
            Console.Write("\nQuantidades de Pessoas: "+ contatos.QtPessoa()+"\n");

            Console.Write("\nInfirme o Nome para a Busca ");
            string busca=Console.ReadLine().ToUpper();
            contatos.BuscaPessoa(busca);
            contatos.Pop();
            contatos.Imprimir();
        }
    }
}
