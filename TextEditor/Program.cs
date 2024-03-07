﻿using System;

namespace TextEditor {
    class Program {
        static void Main(String[] args){
            Console.WriteLine("Hello World");
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

        static void OpenFile(){}

        static void EditFile(){}
    }

}