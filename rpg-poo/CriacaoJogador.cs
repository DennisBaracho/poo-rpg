using rpg_poo;
using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
class CriacaoJogador 
{
    public enum Classes { Samurai = 1, Ninja, Xama }


    public CriacaoJogador(Jogador jogador) 
    {
        {
            Console.Write("\tApós a guerra entre dois poderosos xogunatos, a cidade satélite de Maōmachi tornou-se ruínas. Situada em meio \nao fogo cruzado, " +
                "sofreu ataques de ambos os lados e foi tomada e reconquistada inúmeras vezes. Os três anos de conflito foram suficientes para transformá-la em uma " +
                "região sombria e inóspita, neste momento os poucos que se atrevem a pisar \nem suas terras são ladrões e andarilhos, a atmosfera densa e os Yokais " +
                "nascidos da guerra sufocam qualquer um que passe desavisado. Você, devastado pela culpa de ter abandonado o campo de batalha, está em busca das memórias perdidas de sua família, " +
                "procurando por pistas de uma relíquia de seus ancestrais. Somente assim seu coração terá sossego, viver nas \nsombras como ronin não é mais uma opção." +
                "\n\nObservando seu rosto nas águas do Rio Akaryū, você tenta se lembrar de seu verdadeiro nome, quem você era?\nMeu nome era... ");
            string nomeJogador = Console.ReadLine();
            jogador.Nome = nomeJogador;
            jogador.Nivel = 1;
            jogador.Experiencia = 0;
            Console.WriteLine("\nNos tempos em que fazia a linha de frente, você teve de escolher seu caminho. Qual você escolheu? Ser um samurai, destemido e honrado, " +
                "ou um ninja, ágil e astuto? Quem sabe herdou a sabedoria e a magia dos xamãs. \nA escolha foi sua, ainda deve se lembrar.");
            Console.WriteLine("Selecione sua classe: \n1. Samurai\n2. Ninja\n3. Xamã");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Classes classeSelecionada = (Classes)index;
            switch (classeSelecionada)
            {
                case Classes.Samurai:
                    jogador.Classe = "Samurai";
                    jogador.VidaMax = 25;
                    jogador.Vida = jogador.VidaMax;
                    jogador.ManaMax = 10;
                    jogador.Mana = jogador.ManaMax;
                    jogador.Ataque = 15;
                    jogador.Destreza = 15;
                    break;
                case Classes.Ninja:
                    jogador.Classe = "Ninja";
                    jogador.VidaMax = 15;
                    jogador.Vida = jogador.VidaMax;
                    jogador.ManaMax = 10;
                    jogador.Mana = jogador.ManaMax;
                    jogador.Ataque = 10;
                    jogador.Destreza = 20;
                    break;
                case Classes.Xama:
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
            Console.WriteLine("Ao adentrar o território da cidade, um velho homem te observa e, com uma expressão serena, dá o seguinte aviso: \n\n" +
                "-- Veja só... Ninguém acreditou que o dia viria. Agora, basta que as sete luas toquem o mar. \n   Que sua jornada seja abençoada, "+jogador.Classe+". Até lá, fortaleça seu corpo e espírito, pois precisará.");
            System.Threading.Thread.Sleep(6000);
            Console.Clear();
        }

    }
}
