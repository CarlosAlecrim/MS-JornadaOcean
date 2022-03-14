// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Threading;


using elevador.Model;


namespace elevador

{
    internal class Program{
         static void Main(String[] args){

             Elevador  thyssenkrupp = new Elevador();
             int capacidade = 0;
             int totalAndares = 0;
             int comando = 0;


             Console.WriteLine("Elevador entrando em Operação");
             Thread.Sleep(3000);
             Console.Clear();
             Console.WriteLine("Definir Capacidade do elevador");
             capacidade = int.Parse( Console.ReadLine()) ;
             Console.WriteLine("Definir Total de Andares do Edificio");
             totalAndares = int.Parse( Console.ReadLine());

             thyssenkrupp.Inicializar(capacidade,totalAndares);
             Console.Clear();

             bool continuar = true;       

            //faça
            do
            {
                Console.WriteLine(@" Escolha uma opção:
                                     1 - Entrando
                                     2 - Saindo
                                     3 - Subindo
                                     4 - Descendo
                                     5 - Sair");

                string opcaoEscolhida = Console.ReadLine();
                Console.Clear();

                switch (opcaoEscolhida)
                {
                    case "1": 
                            Console.WriteLine("Entrar");
                            thyssenkrupp.Entrar();    
                            break;
                    case "2":
                            Console.WriteLine("Sair");
                            thyssenkrupp.Sair();
                            break;
                    case "3":
                            Console.WriteLine("Subir");
                            thyssenkrupp.Subir();
                            break;
                    case "4":
                            thyssenkrupp.Descer();
                            Console.WriteLine("Descer");
                            break;
                    case "5": 
                            continuar = false;
                            break;

                    default:
                            Console.WriteLine("Escolha não válida.");
                            break;
                }
            } 
            
            while (continuar); //enquanto for verdadeiro faça.          


         }
    }    
}