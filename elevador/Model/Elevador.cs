using System;
using System.IO;

namespace elevador.Model
{
    public class Elevador
    {
        private int capacidadeMaxima ;
        private int totalAndares;

        private int quantidadePessoas = 0;

        private int andar = 0;


        public void Inicializar(int capacidade, int andares){
            this.capacidadeMaxima = capacidade;
            this.totalAndares = andares;

        }

        public void Entrar()
        {


            if (this.quantidadePessoas == this.capacidadeMaxima){

                Console.WriteLine("Capacidade Atingido - Por favor Aguarde");

            }else if (this.quantidadePessoas < capacidadeMaxima)
            {
                this.quantidadePessoas += 1;
                Console.WriteLine($"Quantidade de Pessoas no Elevador: {this.quantidadePessoas}");
            }
            
        }

        public void Sair( )
        {
            if(this.quantidadePessoas == 0)
            {
                Console.WriteLine("Elevador Vazio.");

            } else if (this.quantidadePessoas > 0)
            {
                this.quantidadePessoas -= 1;
                Console.WriteLine($"Quantidade de Pessoas no Elevador: {this.quantidadePessoas}");
            }
        }

        public void Subir()
        {
          if (this.andar == this.totalAndares)
            {
                Console.WriteLine("Limite Atingido");
                
            }else {
                this.andar += 1;
                Console.WriteLine($"Andar: {this.andar}");
            }   
        }

        public void Descer()
        {
            if (this.andar == 0)
            {
                Console.WriteLine("Térreo.");
                
            }else
            {
                this.andar -= 1;
                if (this.andar == 0)
                {
                    Console.WriteLine("Térreo.");
                
                }else{
                    Console.WriteLine($"Andar: {this.andar}");
                }
                
                
            }
            
        }

    }
}