using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_poo
{
    internal class Program : MenuJogo
    {
        static void Main(string[] args)
        {
            Jogador jogador = new Jogador(); // Instância do jogador
            Monstro monstro = new Monstro(); // Instância do monstro
            CriacaoJogador criacaoJogador = new CriacaoJogador(jogador); // Passando a instância do jogador para CriacaoJogador
            Menu(jogador, monstro); // Passando instâncias para o método Menu
            Console.ReadLine();

        }
    }
}
