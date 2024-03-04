// See https://aka.ms/new-console-template for more information
using System;


namespace Calculator {
    /// <summary>
    /// Programa de calculadora.
    /// </summary>
    class Program {
        static void Main(String[] args) {
            MenuTitulo();
            Menu();
        }

        /// <summary>
        /// Exibe o título do aplicativo para servir de entrada ao iniciar.
        /// </summary>
        static void MenuTitulo(){
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("             CALCULADORA          \n");
        }

        /// <summary>
        /// Menu de escolha e direcionamento das opções da calculadora.
        /// </summary>
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
                case 1: ExecutarOperacao(Soma); break;
                case 2: ExecutarOperacao(Subtracao); break;
                case 3: ExecutarOperacao(Divisao); break;
                case 4: ExecutarOperacao(Multiplicacao); break;
                case 0: System.Environment.Exit(0); break;
                default: Console.WriteLine("Opção não entrada."); Menu(); break;
            }

        }

        /// <summary>
        /// Recebe e transforma as duas entradas de usuários para float.
        /// </summary>
        /// <returns>Uma Tupla com os dois valores em floats.</returns>
        static (float, float) EntradasDeUsuario(){
            // Primeiro valor
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse( Console.ReadLine() ?? "0" );

            // Segundo valor
            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse( Console.ReadLine() ?? "0" );

            return (v1, v2);
        }

        /// <summary>
        /// Função delegate de alta ordem
        /// </summary>
        /// <param name="operacao"></param>
        static void ExecutarOperacao(Func<float, float, float?> operacao){
            Console.Clear();

            // Valores da operação
            (float v1, float v2) = EntradasDeUsuario();

            // Resultado
            float? Resultado = operacao(v1, v2);
            if (Resultado != null) {   
                Console.WriteLine("O resultado da operação é " + Resultado);
            }
            Console.ReadKey();
            Console.Clear(); Menu();
        }

        /// <summary>
        /// Calcula a soma entre dois números.
        /// </summary>
        static float? Soma(float v1, float v2) => v1 + v2;


        /// <summary>
        /// Calcula a substração do primeiro número pelo segundo.
        /// </summary>
        static float? Subtracao (float v1, float v2) => v1 - v2;


        /// <summary>
        /// Calcula a divisão do primeiro número pelo segundo.
        /// </summary>
        static float? Divisao(float v1, float v2){
            // ERROR: Erro de divisão por 0
            bool DividedByZero = v2 == 0;

            if (DividedByZero){
                Console.WriteLine("O divisor não pode ser 0.");
                return null;
            } else {
                // Resultado
                float Resultado = v1 / v2;
                Console.WriteLine($"O resultado é {Resultado}");
                return Resultado;
            }
        }

        /// <summary>
        /// Calcula o múltiplicação entre dois números.
        /// </summary>
        static float? Multiplicacao(float v1, float v2) => v1 * v2;
    }
}