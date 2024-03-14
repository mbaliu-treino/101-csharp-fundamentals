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
            
            DrawScreen(60, 10);
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
    }
}