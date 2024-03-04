// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator {
    class Program {
        static void Main(String[] args) {
            Menu();

            // Primeiro valor
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse( Console.ReadLine() );
            // Console.WriteLine(v1.GetType());

            // Segundo valor
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse( Console.ReadLine() );
            // Console.WriteLine(v2.GetType());

            Soma(v1, v2);

            
        }

        static void Soma(float v1, float v2){
            // Resultado
            float Resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é " + Resultado);
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("==================");
            Console.WriteLine("INICIANDO CALCULADORA\n");
            Console.WriteLine("");

        }
    }
}