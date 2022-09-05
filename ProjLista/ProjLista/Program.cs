using System;

namespace ProjLista {
    internal class Program {
        static void Main(string[] args) {

            int opcao = 0;

            ListaAluno minhalista = new ListaAluno();
            minhalista.Push(new Aluno(123,"JOE",34,"Eng"));
            minhalista.Push(new Aluno(345, "THAISA", 27, "Adm"));
            minhalista.Push(new Aluno(100,"ARIANE",22,"Adm"));

            do {
                Console.WriteLine("\n\t\t\t*** Menu ***\n");
                Console.WriteLine("\n\t\t\t[ 1 ]-Consultar" +
                                  "\n\t\t\t[ 2 ]-Localizar" +
                                  "\n\t\t\t[ 3 ]-Remover" +
                                  "\n\t\t\t[ 0 ]- Sair");
                Console.Write("\n\t\t\tDigite: ");
                opcao = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (opcao) {
                    case 1:
                        minhalista.Print();
                        Console.WriteLine("\n\t\t\t*** Pressione Enter ***\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("\n\t\t\t*** Localizar Aluno ***\n");
                        Console.Write("\n\t\t\tInforme o Nome do Aluno: ");
                        string nombre = Console.ReadLine().ToUpper();
                        minhalista.Locate(nombre);
                        Console.WriteLine("\n\t\t\t*** Pressione Enter ***\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("\n\t\t\t*** Remover Aluno ***\n");
                        Console.Write("\n\t\t\tInforme o Nome do Aluno: ");
                        string name = Console.ReadLine().ToUpper(); 
                        minhalista.Pop(name);
                        Console.WriteLine("\n\t\t\t*** Pressione Enter ***\n");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        if (opcao < 0 || opcao > 3) {
                            Console.WriteLine("\n\t\t\tOpcao Invalida");
                            Console.WriteLine("\n\t\t\t*** Pressione Enter ***\n");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                }
               
            } while (opcao!=0);
                 
        }
    }
}
