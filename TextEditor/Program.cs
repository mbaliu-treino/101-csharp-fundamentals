using System;
using System.IO;

namespace TextEditor {
    class Program {
        static void Main(String[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("O que você desjea fazer?");
            Console.WriteLine("1 - Abrir arquvio");
            Console.WriteLine("2 - Criar novo arquvio");
            Console.WriteLine("0 - Sair");

            short option = short.Parse( Console.ReadLine() ?? "0" );

            switch (option){
                case 0: System.Environment.Exit(0); break;
                case 1: OpenFile(); break;
                case 2: EditFile(); break;
                default: Menu(); break;
            }
        }


        static void OpenFile(){
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string FilePath = Console.ReadLine() ?? "";

            using(var DataFile = new StreamReader(FilePath)){
                string Text = DataFile.ReadToEnd();
                Console.WriteLine(Text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }


        static void EditFile(){
            Console.Clear();
            Console.WriteLine("Digite o seu texto abaixo (ESC para sair)");
            Console.WriteLine("-------------------");

            string Text = "";

            // Entrada de múltiplas linhas
            do{
                Text += Console.ReadLine();
                Text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            SaveFile(Text);
        }


        static void SaveFile(string text){
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            string PathToSave = Console.ReadLine() ?? "";

            // Operação dentro de contexto
            using(var File = new StreamWriter(PathToSave) ){
                File.Write(text);
            }
            Console.WriteLine($"Arquivo {PathToSave} salvo com sucesso!");
            Console.ReadKey();
            Menu();
        }
    }

}