using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ProjFila {
    internal class FilaPessoas {

        public Pessoa HEAD { get; set; }
        public Pessoa TAIL { get; set; }

        public FilaPessoas() {

            HEAD = null;
            TAIL = null;
        }

        public void Push(Pessoa aux) {
            if (Vazia()) {
                HEAD = TAIL = aux;
            }
            else {
                TAIL.Proximo = aux;
                TAIL = aux;
            }

            Console.WriteLine("Inserido com Sucesso!!!");
            Console.ReadKey();
        }

        public void Pop() {

            if (Vazia()) {

                Console.WriteLine("Fila vazia!!");

            }
            else {
                HEAD = HEAD.Proximo;
                if (HEAD == TAIL) {
                    TAIL = null;
                    Console.WriteLine("Elemento Removido!");
                }
            }
            Console.ReadKey();
        }

        public void Imprimir() {
            if (Vazia()) {
                Console.WriteLine("Fila Vazia!!");
            }
            else {
                Pessoa aux = HEAD;
                do {
                    Console.WriteLine(aux.ToString());
                    aux=aux.Proximo;
                } while (aux!=null);
                Console.WriteLine("Fim da Impressao");
            }
            Console.ReadKey();
        }


        public int QtPessoa() {
            
            if (Vazia()) {
                Console.WriteLine("Fila Vazia");
                return 0;
            }
            else {
                int cont = 0;
                Pessoa aux = HEAD;

                do {
                    aux = aux.Proximo;
                    cont++;
                }while (aux!=null);
                return cont;
            }
        }

        public void BuscaPessoa(string nome) {
            if (Vazia()) {
                Console.WriteLine("Fila Vazia!");
            }
            else {
                Pessoa aux = HEAD;
                do {
                    aux=aux.Proximo;
                    if (aux.Nome.Equals(nome)) {
                       Console.WriteLine(aux.ToString());
                        Console.ReadKey();
                    }
                }while(aux!=null);
            }
        }
        
        public bool Vazia() {
            if ((HEAD == null) && (TAIL == null)) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
