using System;
using System.Text.RegularExpressions;

namespace EditorHtml{
    public class Viewer{
        public static void Show(string text){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO DE VISUALIZAÇÃO");
            Console.WriteLine("--------------------");
            Replace(text);
            Console.WriteLine("--------------------");
            Console.ReadKey();
            Menu.Show();
            
            }

        public static void Replace(string text){
            var Strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            // Console.WriteLine(strong);  // imprimi o valor da regex
            var Words = text.Split(' ');

            for (var i = 0; i < Words.Length; i++){
                if (Strong.IsMatch(Words[i])){
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        Words[i].Substring(
                            Words[i].IndexOf('>') + 1, 
                            (
                                (Words[i].LastIndexOf('<') - 1) - Words[i].IndexOf('>')
                            )
                        )
                    );
                    Console.Write(" ");
                } else {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(Words[i]);
                    Console.Write(" ");
                }
            }
            Console.Write("\n");
        }
    }
}