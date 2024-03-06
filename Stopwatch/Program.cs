using System;
using System.Threading;

namespace Stopwatch{
    class Program{
        /// <summary>
        /// Programa de cronômetro.
        /// </summary>
        static void Main(String[] args){
            // Inicialização do menu
            Menu();
        }

        
        /// <summary>
        /// Menu de inicialização da aplicação.
        /// </summary>
        static void Menu(){
            Console.Clear();

            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");

            Console.WriteLine("Quanto tempo deseja contar?");
            string Data = Console.ReadLine() ?? "";

            // Opção de saída
            if (Data == "0"){
                System.Environment.Exit(0);
            }

            // Transformação da entrada para segundos
            int TimeValue = TransformarEntradaDeUsuario(Data);

            // Execução do cronômetro
            PreStart(TimeValue);
        }


        /// <summary>
        /// Pré-execução do cronômetro.
        /// </summary>
        static void PreStart(int Time){
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);

            Start(Time);
        }


        /// <summary>
        /// Transformação do dado de entrada do usuário para segundos.
        /// </summary>
        /// <returns>Tempo de espera em segundos.</returns>
        static int TransformarEntradaDeUsuario(string entrada){
            
            // Extração de informações da entrada de usuário
            entrada = entrada.ToLower();
            char MetricType = char.Parse( entrada.Substring( entrada.Length-1, 1) );
            int TimeValue = int.Parse( entrada.Substring( 0, entrada.Length-1 ) );

            // Padronização do valor de tempo para segundos
            int Multiplier = 0;
            if (MetricType == 'm'){
                // Conversão de minutos
                Multiplier = 60;
            } else if (MetricType == 's'){
                // Conversão neutra
                Multiplier = 1;
            } else {
                // Erro de entrada
                Console.WriteLine("Unidade de medida inválida!");
                Thread.Sleep(2500);
                Menu();
            }
            return TimeValue * Multiplier;
    }


        /// <summary>
        /// Execução do mecanismo de cronômetro.
        /// </summary>
        static void Start(int time){
            int CurrentTime = time;

            while (CurrentTime != 0){
                Console.Clear();
                Console.WriteLine(CurrentTime);
                CurrentTime--;
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }

    }
}
