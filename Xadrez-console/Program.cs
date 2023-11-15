﻿using System;
using tabuleiro;
using Xadrez;
using Xadrez_console;

namespace xadrez_console {
    class Progream {
        static void Main(string[] args) {

            Tabuleiro tab = new Tabuleiro(8,8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta),new Posicao(2, 4));

            Tela.imprimirTabuleiro(tab);
        }
    }
}