using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rpg_poo
{
    enum OpcaoMelhorar { Vida = 1, Ataque = 2, Destreza = 3 }
    internal class Jogador 
    {
        // Atributos do Jogador
        private string nome;
        private string classe;
        private int nivel;
        private int vida;
        private int vidaMax;
        private int mana;
        private int manaMax;
        private int ataque;
        private int destreza;
        private int foraDeCombate;
        private int experiencia;

        // Get e Set
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Classe
        {
            get { return classe; }
            set { classe = value; }
        }

        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
        public int Experiencia
        {
            get { return experiencia; }
            set { experiencia = value; }
        }
        public int Vida
        {
            get { return vida; }
            set { vida = value; }
        }
        public int VidaMax
        {
            get { return vidaMax; }
            set { vidaMax = value; }
        }
        public int Mana
        {
            get { return mana; }
            set { mana = value; }
        }
        public int ManaMax
        {
            get { return manaMax; }
            set { manaMax = value; }
        }
      
        public int Ataque
        {
            get { return ataque; }
            set { ataque = value; }
        }
        public int Destreza
        {
            get { return destreza; }
            set { destreza = value; }
        }
        public int ForaDeCombate
        {
            get { return foraDeCombate; }
            set { foraDeCombate = value; }
        }

        public static void SubirNivel(Jogador jogador)

        {

            while (jogador.Experiencia >= 300 + (jogador.Nivel * 300))
            {
                jogador.Experiencia -= (300 + (jogador.Nivel * 300));
                jogador.Nivel++;
                Console.WriteLine("\nVocê subiu para o nível " + jogador.Nivel + "!");
                Console.WriteLine("Selecione que atributo deseja melhorar:\n1. Vida     2. Ataque     3. Destreza");
                int menuUp = int.Parse(Console.ReadLine());
                OpcaoMelhorar opcaoMelhorarSelecionada = (OpcaoMelhorar)menuUp;
                switch (opcaoMelhorarSelecionada)
                {
                    case OpcaoMelhorar.Vida:
                        jogador.VidaMax += 6;
                        break;
                    case OpcaoMelhorar.Ataque:
                        jogador.Ataque += 2;
                        break;
                    case OpcaoMelhorar.Destreza:
                        jogador.Destreza += 2;
                        break;


                }
            }
        }


    public static void AtaqueEspecial(Jogador  jogador, Monstro monstro) 
        {
            if ((jogador.Classe == "Samurai") && (jogador.ForaDeCombate == 0))
            {
                jogador.Vida += jogador.VidaMax / 2;
                if (jogador.Vida > jogador.VidaMax)
                {
                    jogador.Vida = jogador.VidaMax;
                }
                Console.WriteLine("Você persiste e cura seus ferimentos! \nPontos de vida atuais: (" + jogador.Vida + "/" + jogador.VidaMax + ")");
                jogador.Mana -= 5;
            }
            else if (jogador.Classe == "Ninja" && (jogador.ForaDeCombate == 0))
            {
                Random Dano = new Random();
                int rolagemDano = Dano.Next(3, 10) + (jogador.Destreza - 10) / 2;
                monstro.Vida -= rolagemDano;
                jogador.Mana -= 2;
                Console.WriteLine("Você golpeia as costas do inimigo com um ataque furtivo! Você causou " + rolagemDano + " de dano!\n");

            }
            else if (jogador.Classe == "Xamã" && (jogador.ForaDeCombate == 0))
            {
                Random Dano = new Random();
                int rolagemDano = Dano.Next(1, 6) + (jogador.Ataque - 10) / 2;
                monstro.Vida -= rolagemDano;
                jogador.Mana -= 5;
                jogador.Vida += rolagemDano;
                Console.WriteLine("Você rouba um pouco da vida do inimigo! Com sua magia, você toma " + rolagemDano / 2 + " pontos de vida!");
            }
        }
    }
}
