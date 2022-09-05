using System;


namespace ProjLista {
    internal class ListaAluno {


        public Aluno HEAD { get; set; }

        public Aluno TAIL { get; set; }

        public ListaAluno() {

            HEAD = TAIL = null;
        }

        private bool Vazia() {
            if ((HEAD == null) && (TAIL == null)) {
                return true;

            }
            else {
                return false;
            }
        }

        public void Print() {
            Aluno aux;

            if (Vazia()) {
                Console.WriteLine("\n\t\t\tLista Vazia!!!");
               
            }
            else {
                aux = HEAD;

                Console.WriteLine("\n\t\t\tDados da Lista de Alunos: ");
                do {
                    Console.WriteLine(aux.ToString() + "\n");
                    aux = aux.Proximo;

                } while (aux != null);
                Console.WriteLine("\n\t\t\tFim da Impressão!!!");
            }
        }

        public void Push(Aluno aux) {
            //Inserção Lista Vazia
            if (Vazia()) {
                HEAD = TAIL = aux;
            }
            else {
                //Lembrando que a Inserção de ve seguir um Ordenação 
                //Neste Exemplo faremos a Ordem Alfébetica por Nome do Aluno
                //Inserção após a Tail(Novo Ultimo Elemento)
                if (aux.Nome.CompareTo(TAIL.Nome) >= 0) {

                    TAIL.Proximo = aux;//Inserindo um Novo objeto como Último
                    TAIL = aux; //Ajustando a Tail para o Novo Último Elemento
                }
                else { //Inserção Antes da Headl(Novo Primeiro Elemento)
                    if (aux.Nome.CompareTo(HEAD.Nome) < 0) {
                        aux.Proximo = HEAD;//Faço encadeamento do Novo 1º elemento  da Lista
                        HEAD = aux;//Ajustando a HEAD para o Novo 1º elemento da Lista
                    }
                    else {//Inserção no Meio da Lista

                        Aluno aux1, aux2;
                        aux1 = this.HEAD;
                        aux2 = this.HEAD;

                        do {
                            if (aux.Nome.CompareTo(aux1.Nome) >= 0) {
                                //Procurando a Posição para Inseriri um Novo Objet
                                aux2 = aux1;//Controlar o "Anterior"
                                aux1 = aux1.Proximo;//Controlar o "Proximo"
                            }
                            else {
                                aux2.Proximo = aux;//Encadeamento do Objeto anterior
                                aux.Proximo = aux1;//Encandeamento do Objeo Proximo
                                break;
                            }

                        } while (true);
                    }
                }

            }

        }
        public void Locate(string name) {

            if (Vazia()) {
                Console.WriteLine("\n\t\t\tLista Vazia!!!");
            }
            else {
                Aluno aux = HEAD;
                do {

                    if (aux.Nome.Equals(name)) {
                        Console.WriteLine(aux.ToString());

                    }
                    aux = aux.Proximo;


                } while (aux != null);

            }
        }

        public void Pop(string name) {

           
            if (Vazia()) {
                Console.WriteLine("\n\t\t\tLista Vazia!!!");
            }
            if (name.Equals(HEAD.Nome) && name.Equals(TAIL.Nome)) {
                HEAD = null;
                TAIL = null;
                Console.WriteLine("\n\t\t\tAluno removido com Sucesso");
            }
           
            else if (name.Equals(HEAD.Nome)) {
                HEAD = HEAD.Proximo;
                Console.WriteLine("\n\t\t\tAluno removido com sucesso");
            }
            else {
                Aluno aux = HEAD;
                Aluno aux1 = HEAD.Proximo;
                do {
                  
                    if (aux1 == null) {
                        Console.WriteLine("\n\t\t\tNome não Encontrado!!");
                    }else if (name.Equals(aux1.Nome)) {
                        aux.Proximo = aux1.Proximo;
                    }
                    
                    aux = aux.Proximo;
                    aux1 = aux1.Proximo;

                } while (aux1 != null);

                Console.WriteLine("\n\t\t\tAluno removido com sucesso");
            }
        }
    }
















}
