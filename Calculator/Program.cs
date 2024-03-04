// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator {
    class Program {
        static void Main(String[] args) {
            Menu();
          
        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("====================================");
            Console.WriteLine("       CALCULADORA      \n");
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("\nSelecione uma opção: ");
            short EntradaUsuario = short.Parse( Console.ReadLine() );

            // Escolha da operação (Strategy)
            switch (EntradaUsuario) {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Console.WriteLine("Opção não entrada."); Menu(); break;
            }

        }


        static void Soma(){
            Console.Clear();

            // Primeiro valor
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse( Console.ReadLine() );

            // Segundo valor
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse( Console.ReadLine() );

            // Resultado
            float Resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é " + Resultado);
        }

        static void Subtracao (){
            Console.Clear();

            // Primeiro valor
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse( Console.ReadLine() );

            // Segundo valor
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse( Console.ReadLine() );

            // Resultado
            float Resultado = v1 - v2;
            Console.WriteLine($"O resultado da soma é {Resultado}");
            Console.ReadKey();
        }

        static void Divisao(){
            Console.Clear();

            // Primeiro valor
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse( Console.ReadLine() );

            // Segundo valor
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse( Console.ReadLine() );

            // Resultado
            float Resultado = v1 / v2;
            // ERROR: Erro de divisão por 0
            Console.WriteLine($"O resultado é {Resultado}");
            Console.ReadKey();
        }

        static void Multiplicacao(){
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse( Console.ReadLine() );

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse( Console.ReadLine() );

            float Resultado = v1 * v2;
            Console.WriteLine($"O resultado é {Resultado}");
        }

        
    }
}