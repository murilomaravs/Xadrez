using System;
using tabuleiro;
using Xadrez_console;

namespace xadrez_console {
    class Progream {
        static void Main(string[] args) {

            Tabuleiro tab = new Tabuleiro(8,8);

            Tela.imprimirTabuleiro(tab);
        }
    }
}