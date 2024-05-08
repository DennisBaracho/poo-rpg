using rpg_poo;
using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
class CriacaoJogador 
{
    public enum Classes { Samurai = 1, Ninja = 2, Xama = 3 }
    

    public CriacaoJogador(Jogador jogador) 
    {
        {
            Console.WriteLine("Ah, você apareceu. Diga-me, qual é o seu nome? Não há necessidade de ocultar sua identidade aqui. " +
                "\nNeste vasto mundo, seu nome será a lenda que ecoará através dos tempos.");
            string nomeJogador = Console.ReadLine();
            jogador.Nome = nomeJogador;
            jogador.Nivel = 1;
            jogador.Experiencia = 0;
            Console.WriteLine("\nMas antes de começarmos essa jornada épica, você deve escolher seu caminho. Você será um samurai, destemido e honrado, " +
                "\nou um ninja, ágil e astuto? Talvez você prefira a sabedoria dos monges ou a magia dos xamãs. \nA escolha é sua, e o destino aguarda " +
                "ansiosamente sua decisão.");
            Console.WriteLine("Selecione sua classe: \n1. Samurai\n2. Ninja\n3. Xamã");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Classes classeSelecionada = (Classes)index;
            switch (classeSelecionada)
            {
                case Classes.Samurai:
                    Console.WriteLine("Então você é um samurai...");
                    jogador.Classe = "Samurai";
                    jogador.VidaMax = 25;
                    jogador.Vida = jogador.VidaMax;
                    jogador.ManaMax = 10;
                    jogador.Mana = jogador.ManaMax;
                    jogador.Ataque = 10;
                    jogador.Destreza = 10;
                    break;
                case Classes.Ninja:
                    Console.WriteLine("Então você é um ninja...");
                    jogador.Classe = "Ninja";
                    jogador.VidaMax = 15;
                    jogador.Vida = jogador.VidaMax;
                    jogador.ManaMax = 10;
                    jogador.Mana = jogador.ManaMax;
                    jogador.Ataque = 10;
                    jogador.Destreza = 20;
                    break;
                case Classes.Xama:
                    Console.WriteLine("Então você é um xamã...");
                    jogador.Classe = "Xamã";
                    jogador.VidaMax = 20;
                    jogador.Vida = jogador.VidaMax;
                    jogador.ManaMax = 10;
                    jogador.Mana = jogador.ManaMax;
                    jogador.Ataque = 25;
                    jogador.Destreza = 5;
                    break;
                default:
                    Console.WriteLine("Não existe essa opção");
                    break;
            }
        }

    }
}
