using System;

namespace ProjPilhaDinamica {
    internal class Program {
        static void Main(string[] args) {

            int op = 0;
            PilhaLivros minhaPilha = new PilhaLivros();

            // minhaPilha.Print();

            // Livro livro = new Livro("Show",123,"THOR");
            /* minhaPilha.Push(livro);


             minhaPilha.Push(new Livro("Dois", 230, "Lara"));

             minhaPilha.Print();

             minhaPilha.Pop();
             minhaPilha.Print();

             minhaPilha.Pop();
             minhaPilha.Print();


             minhaPilha.Pop();*/
            do {
               
                    Console.Clear();
                    Console.WriteLine("\n**** Menu ***\n");
                    Console.WriteLine("Inserir Livro na Pilha [1]");
                    Console.WriteLine("Remover Livro da Pilha[2]");
                    Console.WriteLine("Imprimir a Pilha [3]");
                    Console.WriteLine("Imprimir a quatidade de Livros na Pilha[4]");
                    Console.WriteLine("Localizar Livro na Pilha[5]");
                    Console.WriteLine("Sair[0]");
                    Console.Write("\nDigite: ");
                    op = int.Parse(Console.ReadLine());
                

                switch (op) {

                    case 0:
                        Console.WriteLine();
                        break;

                    case 1:
                        Console.WriteLine("\nInserir Livro na Pilha\n");

                        Console.Write("Informe o Titulo do Livro: ");
                        string tt = Console.ReadLine();
                        Console.Write("Informe o Nome do Autor do Livro: ");
                        string at = Console.ReadLine();
                        Console.Write("Informe o ISBN: ");
                        int id = int.Parse(Console.ReadLine());

                        minhaPilha.Push(new Livro(tt, id, at));
                        break;

                    case 2:
                        Console.WriteLine("Remover Livro da Pilha");
                        minhaPilha.Pop();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Imprimir Pilha");
                        minhaPilha.Print();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Write("\nImprimir a quatidade de Livros na Pilha: ");
                       Console.WriteLine( minhaPilha.QuantidadePilha());
                        Console.ReadKey();
                        break;

                    case 5:

                        Console.WriteLine("Localizar Livro na Pilha");
                        Console.Write("Informe o Titulo do Livro que quer Localizar: ");
                        string localiza = Console.ReadLine();
                        minhaPilha.LocalizaLivro(localiza);
                        Console.ReadKey();
                        break;
                    default:

                        Console.WriteLine("Opcao Invaida");
                        Console.ReadKey();
                        break;



                }
            } while (op != 0);

        }

    }
}

