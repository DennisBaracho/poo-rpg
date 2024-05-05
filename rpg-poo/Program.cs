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
            CriacaoJogador c = new CriacaoJogador();
            Menu();
            Console.ReadLine();
        }
    }
}
