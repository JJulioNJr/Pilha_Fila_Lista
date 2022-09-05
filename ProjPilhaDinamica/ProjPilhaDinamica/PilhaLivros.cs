using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjPilhaDinamica {
    internal class PilhaLivros {

        public Livro TOPO { get; set; }

        public PilhaLivros() {

            this.TOPO = null;
            Console.WriteLine("Pilha Criada com Sucesso!!!");

        }

        public void Push(Livro aux) {
            if (Vazia())
                TOPO = aux;
            else {
                aux.Anterior = TOPO;
                TOPO = aux;
            }

        }

        public void Pop() {
            if (Vazia()) {
                Console.WriteLine("\nPilha Está Vazia");
            }
            else {
                TOPO = TOPO.Anterior;
            }

        }

        public void Print() {

            if (Vazia()) {
                Console.WriteLine("\nPilha Vazia!!!");
            }
            else {
                Livro aux = TOPO;
                do {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                } while (aux != null);
                Console.WriteLine("Fim da Impressão!!!");
            }


        }

        private bool Vazia() {

            if (this.TOPO == null) {
                return true;
            }
            else {
                return false;
            }


        }


        public int QuantidadePilha() {


            if (Vazia()) {
                return 0;
                 
            }
            else {
              
                Livro aux = TOPO ;
                int cont = 0;
                do {
                   
                    cont++;
                    aux=aux.Anterior;
                   
                } while(aux!=null);
                return cont;
            }
            

        }

        public void LocalizaLivro(string lc) {

            if (Vazia()) {
                Console.WriteLine("\nPilha Vazia!!!");
            }
            else {
                Livro aux = TOPO;
                bool achou = false;
                do {
                    if (TOPO.Titulo.Equals(lc)) {
                        Console.WriteLine(TOPO.ToString());
                        Console.ReadKey();
                    }
                    aux = aux.Anterior;
                } while (aux != null);
                if (!achou) {
                    Console.WriteLine("\nLivro não Localizado!!!");
                }
                else {
                    Console.WriteLine("\nFim da Bunca!!!");
                    Console.ReadKey();
                }
            }

        }
    }
}
