// See https://aka.ms/new-console-template for more information
using System;

namespace Calculator {
    class Program {
        static void Main(String[] args) {
            MenuTitulo();
            Menu();
          
        }

        static void MenuTitulo(){
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("             CALCULADORA          \n");
        }

        static void Menu(){
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("\nSelecione uma opção: ");
            short EntradaUsuario = short.Parse( Console.ReadLine() ?? "0");

            // Escolha da operação (Strategy)
            switch (EntradaUsuario) {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 0: System.Environment.Exit(0); break;
                default: Console.WriteLine("Opção não entrada."); Menu(); break;
            }

        }

        static (float, float) EntradasDeUsuario(){
            // Primeiro valor
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse( Console.ReadLine() ?? "0" );

            // Segundo valor
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse( Console.ReadLine() ?? "0" );

            return (v1, v2);
        }

        static void Soma(){
            Console.Clear();

            // Valores da operação
            (float v1, float v2) = EntradasDeUsuario();

            // Resultado
            float Resultado = v1 + v2;
            Console.WriteLine("O resultado da soma é " + Resultado);
            Console.ReadKey();
            Console.Clear(); Menu();
        }

        static void Subtracao (){
            Console.Clear();

            // Valores da operação
            (float v1, float v2) = EntradasDeUsuario();

            // Resultado
            float Resultado = v1 - v2;
            Console.WriteLine($"O resultado da soma é {Resultado}");
            Console.ReadKey();
            Console.Clear(); Menu();
        }

        static void Divisao(){
            Console.Clear();

            // Valores da operação
            (float v1, float v2) = EntradasDeUsuario();

            // ERROR: Erro de divisão por 0
            bool DividedByZero = v2 == 0;

            if (DividedByZero){
                Console.WriteLine("O divisor não pode ser 0. O valor tende a inf (∞)");
            } else {
                // Resultado
                float Resultado = v1 / v2;
                Console.WriteLine($"O resultado é {Resultado}");
            }

            Console.ReadKey();
            Console.Clear(); Menu();
        }

        static void Multiplicacao(){
            Console.Clear();

            // Valores da operação
            (float v1, float v2) = EntradasDeUsuario();

            float Resultado = v1 * v2;
            Console.WriteLine($"O resultado é {Resultado}");
            Console.ReadKey();
            Console.Clear(); Menu();
        }

        
    }
}