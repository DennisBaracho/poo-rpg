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
            Jogador jogador = new Jogador(); 
            Monstro monstro = new Monstro(); 
            CriacaoJogador criacaoJogador = new CriacaoJogador(jogador); 
            Menu(jogador, monstro); 
            Console.ReadLine();

        }
    }
}
