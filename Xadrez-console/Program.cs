using System;
using tabuleiro;
using Xadrez;
using Xadrez_console;

namespace xadrez_console {
    class Progream {
        static void Main(string[] args) {

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());

        }
    }
}
