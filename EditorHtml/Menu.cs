using System;

namespace EditorHtml
{
    public static class Menu{

        public static void Show()
        {
            Console.Clear();
            
            // Configuração do console
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            
            DrawScreen(30, 10);
            WriteOptions();

            var Option = short.Parse(Console.ReadLine());
            HandleMenuOption(Option);
        }

        public static void DrawScreen(int largura, int altura)
        {
            // Cabeçalho
            DrawLine(largura, "+", "-");

            // Corpo
            for(int lines = 0; lines <= altura; lines++)
            {
                DrawLine(largura, "|", " ");
            }

            // Roda pé
            DrawLine(largura, "+", "-");
        }

        public static void DrawLine(int largura, string StartChar, string BodyChar)
        {
            Console.Write(StartChar);
            for (int i = 0; i <= largura; i++)
            {
                Console.Write(BodyChar);
            }
            Console.Write(StartChar);
            Console.Write("\n");
        }

        public static void WriteOptions(){
            Console.SetCursorPosition(3, 2);  // coluna e linha
            Console.WriteLine("        EDITOR HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=========================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Escolha uma opção:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir arquivo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option){
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
                default: Show(); break;
            }
        }
    }
}