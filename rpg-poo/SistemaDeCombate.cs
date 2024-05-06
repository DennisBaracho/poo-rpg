using rpg_poo;
using System;
using System.Diagnostics.Eventing.Reader;
class SistemaDeCombate
{
    enum OpcaoCombate { Atacar = 1, Fugir = 2, Inspecionar = 3 }

    public static void Limpar(int tempo)
    {
        System.Threading.Thread.Sleep(tempo);
        Console.Clear();
    }

    public static void Combate(Jogador jogador, Monstro monstro) 
    {
        int seuTurno;
        Console.WriteLine("\nUm " + monstro.Nome + " aparece a sua frente!");
        if (jogador.Destreza > monstro.Destreza)
        {
            seuTurno = 1;
            monstro.Vida = monstro.VidaMax;
            jogador.ForaDeCombate = 0;
            Console.WriteLine("Você ataca primeiro!");
        }
        else
        {
            seuTurno = 0;
            monstro.Vida = 20;
            jogador.ForaDeCombate = 0;
            Console.WriteLine(monstro.Nome + " ataca primeiro!");
        }

        while ((jogador.ForaDeCombate == 0) && (monstro.Vida > 0) && (jogador.Vida > 0))
        {
            if (seuTurno == 1)
            {
                Console.WriteLine("O que quer fazer? \n1. Atacar\n2. Fugir\n3. Status");
                int menuCombate = int.Parse(Console.ReadLine());
                OpcaoCombate opcaoCombateSelecionada = (OpcaoCombate)menuCombate;
                switch (opcaoCombateSelecionada)
                {
                    case OpcaoCombate.Atacar:
                        Random Ataque = new Random();
                        int rolagemAtaque = Ataque.Next(1, 20) + (jogador.Ataque - 10) / 2;
                        Console.WriteLine("\nRolagem de ataque: " + rolagemAtaque + "!");
                        if (rolagemAtaque >= monstro.Destreza)
                        {
                            Random Dano = new Random();
                            int rolagemDano = Dano.Next(1, 10) + (jogador.Ataque - 10) / 2;
                            Console.WriteLine("Você acertou o ataque! Você causou " + rolagemDano + " de dano!\n");
                            monstro.Vida -= rolagemDano;
                            seuTurno = 0;
                            Limpar(1500);
                            if (monstro.Vida <= 0)
                            {
                                Console.WriteLine("Você venceu o combate!\n" + monstro.Nome + " concede " + monstro.Experiencia + " de experiência!");
                                jogador.Experiencia += monstro.Experiencia;
                                SubirNivel(jogador);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Você errou o ataque!\n");
                            seuTurno = 0;
                            Limpar(1500);
                        }
                        break;
                    case OpcaoCombate.Fugir:
                        if (jogador.Destreza >= monstro.Destreza)
                        {
                            jogador.ForaDeCombate = 1;
                            Console.WriteLine("Você fugiu!");
                        }
                        else
                        {
                            jogador.ForaDeCombate = 0;
                            Console.WriteLine("Você está preso!");
                            seuTurno = 0;
                        }
                        break;
                    case OpcaoCombate.Inspecionar:
                        Console.WriteLine("\nVida de Dennis: (" + jogador.Vida + "/" + jogador.VidaMax + ").\nDano causado ao monstro: " + (monstro.VidaMax - monstro.Vida));
                        seuTurno = 1;
                        break;
                    default:
                        Console.WriteLine("Não existe essa opção");
                        break;
                }
            }
            else if (seuTurno == 0)
            {
                Console.WriteLine("É o turno de " + monstro.Nome + "! Ele prepara seu ataque!");
                Random Ataque = new Random();
                int rolagemAtaque = Ataque.Next(1, 20) + (monstro.Ataque - 10) / 2;
                Console.WriteLine("Rolagem de ataque do monstro: " + rolagemAtaque + ".");
                if (rolagemAtaque >= jogador.Destreza)
                {
                    Random Dano = new Random();
                    int rolagemDano = Dano.Next(1, 10) + (monstro.Ataque - 10) / 2;
                    Console.WriteLine("O " + monstro.Nome + " te acerta! Você sofreu " + rolagemDano + " de dano!\n");
                    jogador.Vida -= rolagemDano;
                    seuTurno = 1;
                    if (jogador.Vida <= 0)
                    {
                        Console.WriteLine("Você morreu.");
                        Limpar(4000);
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Você desvia do ataque!\n");
                    seuTurno = 1;
                }
            }
        }
    }

    public static void SubirNivel(Jogador jogador) 
    {
        while (jogador.Experiencia >= 300 + (jogador.Nivel * 300))
        {
            jogador.Experiencia -= (300 + (jogador.Nivel * 300));
            jogador.Nivel++;
            Console.WriteLine("Você subiu para o nível " + jogador.Nivel + "!");
        }
    }
}
