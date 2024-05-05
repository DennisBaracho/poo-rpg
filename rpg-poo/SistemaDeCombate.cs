using System;
using System.Diagnostics.Eventing.Reader;
abstract class SistemaDeCombate
    {
    enum OpcaoCombate { Atacar = 1, Fugir = 2, Inspecionar = 3}
    // Atributos do Monstro
    public static string nomeMonstro = "Fukuki";
    public static double experienciaMonstro = 150;
    // Atributos de combate do Monstro
    public static int vidaMaximaMonstro = 20;
    public static int vidaMonstro;
    public static int ataqueMonstro = 15;
    public static int destrezaMonstro = 10;
    

    // Atributos do Jogador
    public static string nomeJogador;
    public static int nivelJogador;
    public static double experienciaJogador;
    public static string classeJogador;

    // Atributos de combate do Jogador
    public static int vidaMaxima;
    public static int vidaAtual;
    public static int ataqueJogador;
    public static int destrezaJogador;
    public static int fugiu = 0;

    public static void Limpar(int tempo)
    {
        System.Threading.Thread.Sleep(tempo);
        Console.Clear();
    }

    public static void Combate()
    {
        int seuTurno;
        Console.WriteLine("\nUm " + nomeMonstro + " aparece a sua frente!");
        if (destrezaJogador > destrezaMonstro)
        {
            seuTurno = 1;
            vidaMonstro = vidaMaximaMonstro;
            fugiu = 0;
            Console.WriteLine("Você ataca primeiro!");
        }
        else
        {
            seuTurno = 0;
            vidaMonstro = 20;
            fugiu = 0;
            Console.WriteLine(nomeMonstro+" ataca primeiro!");
        }

        while ((fugiu == 0) && (vidaMonstro > 0) && (vidaAtual > 0)){ 
        if (seuTurno == 1)
        {
            Console.WriteLine("O que quer fazer? \n1. Atacar\n2. Fugir\n3. Status");
            int menuCombate = int.Parse(Console.ReadLine());
            OpcaoCombate opcaoCombateSelecionada = (OpcaoCombate)menuCombate;
            switch (opcaoCombateSelecionada)
            {
                case OpcaoCombate.Atacar:
                    Random Ataque = new Random();
                    int rolagemAtaque = Ataque.Next(1, 20)+(ataqueJogador-10)/2;
                    Console.WriteLine("\nRolagem de ataque: "+rolagemAtaque + "!");
                    if (rolagemAtaque >= destrezaMonstro)
                    {
                        Random Dano = new Random();
                        int rolagemDano = Dano.Next(1, 10)+(ataqueJogador-10)/2;
                        Console.WriteLine("Você acertou o ataque! Você causou " +rolagemDano+" de dano!\n");
                        vidaMonstro = vidaMonstro - rolagemDano;
                        seuTurno = 0;
                        Limpar(1500);
                            if(vidaMonstro <= 0)
                            {
                                Console.WriteLine("Você venceu o combate!\n" + nomeMonstro + " concede " + experienciaMonstro+" de experiência!");
                                experienciaJogador += experienciaMonstro;
                                SubirNivel();
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
                   if (destrezaJogador >= destrezaMonstro)
                    {
                            fugiu = 1;
                            Console.WriteLine("Você fugiu!");
                        }
                        else
                        {
                            fugiu = 0;
                            Console.WriteLine("Você está preso!");
                            seuTurno = 0;
                        }
                    break;
                    case OpcaoCombate.Inspecionar:
                        Console.WriteLine("\nVida de Dennis: ("+ vidaAtual + "/" + vidaMaxima + ").\nDano causado ao monstro: "+(vidaMaximaMonstro-vidaMonstro));
                        seuTurno = 1;
                        break;
                default:
                    Console.WriteLine("Não existe essa opção");
                    break;
            }

        } else if (seuTurno == 0)
        {
                Console.WriteLine("É o turno de " + nomeMonstro + "! Ele prepara seu ataque!");
                Random AtaqueMonstro = new Random();
                int rolagemAtaqueMonstro = AtaqueMonstro.Next(1, 20) + (ataqueMonstro - 10) / 2;
                Console.WriteLine("Rolagem de ataque do monstro: "+rolagemAtaqueMonstro + ".");
                if (rolagemAtaqueMonstro >= destrezaJogador)
                {
                    Random DanoMonstro = new Random();
                    int rolagemDanoMonstro = DanoMonstro.Next(1, 10) + (ataqueMonstro - 10) / 2;
                    Console.WriteLine("O " + nomeMonstro + " te acerta! Você sofreu " + rolagemDanoMonstro + " de dano!\n");
                    vidaAtual = vidaAtual - rolagemDanoMonstro;
                    seuTurno = 1;
                    if (vidaAtual <= 0)
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
    public static void SubirNivel()
    {
        while(experienciaJogador >= 300 + (nivelJogador * 300))
        {
            experienciaJogador = experienciaJogador - (300 + (nivelJogador * 300));
            nivelJogador++;
            Console.WriteLine("Você subiu para o nível " + nivelJogador + "!");
        }
    }
}
