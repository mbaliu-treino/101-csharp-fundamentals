using System;
using System.Threading;

namespace Stopwatch{
    class Program{
        static void Main(String[] args){
            // Start(6);
            Menu();
        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");

            Console.WriteLine("Quanto tempo deseja contar?");
            string Data = Console.ReadLine() ?? "";


            // Extração de informações da entrada de usuário
            Data = Data.ToLower();
            char MetricType = char.Parse( Data.Substring( Data.Length-1, 1) );
            int TimeValue = int.Parse( Data.Substring( 0, Data.Length-1 ) );

            // Padronização do valor de tempo para segundos
            int Multiplier = 1;
            if (MetricType == 'm'){
                Multiplier = 60;
            }

            // Caso o valor seja 0
            // if (TimeValue == 0){
            //     Menu();
            //     System.Environment.Exit(0);
            // }

            // Execução do cronômetro
            Start(TimeValue * Multiplier);

        }

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

        static void Start(int time){
            int CurrentTime = 0;

            while (time != CurrentTime){
                Console.Clear();
                CurrentTime++;
                Console.WriteLine(CurrentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }

    }
}
