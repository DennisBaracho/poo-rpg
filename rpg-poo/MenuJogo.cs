using rpg_poo;
using System;
class MenuJogo : SistemaDeCombate
{
    enum Opcao { Cacar = 1, Dormir, Eu, DiasAte }

    public static void Menu(Jogador jogador, Monstro monstro)
    {
        {
            int diasParaInvasao = 7;

            while (diasParaInvasao > 0)
            {
                Console.WriteLine("O que quer fazer? \n1. Caçar\n2. Dormir\n3. Me inspecionar \n4. Verificar dias até invasão");
                int menu = int.Parse(Console.ReadLine());
                Opcao opcaoSelecionada = (Opcao)menu;
                switch (opcaoSelecionada)
                {
                    case Opcao.Cacar:
                        Combate(jogador, monstro);
                        break;
                    case Opcao.Dormir:
                        Console.WriteLine("\nVocê está descansado!");
                        diasParaInvasao--;
                        jogador.Vida = jogador.VidaMax;
                        break;
                    case Opcao.Eu:
                        Console.WriteLine("\nMeu nome é " + jogador.Nome + ".\nNível: " + jogador.Nivel + "\nClasse: " + jogador.Classe + ". " +
                            "Meus atributos são: \nVida: (" + jogador.Vida + "/" + jogador.VidaMax + ") \nAtaque: " + jogador.Ataque + "\nDestreza: " + jogador.Destreza +
                            "\nPontos de experiência: (" + jogador.Experiencia + "/" + (300 + (jogador.Nivel * 300)) + ")");
                        break;
                    case Opcao.DiasAte:
                        Console.WriteLine("\nFaltam " + diasParaInvasao + " dias para a invasão.");
                        break;
                    default:
                        Console.WriteLine("\nNão existe essa opção");
                        break;
                }
                Limpar(2000);
            }
            if (diasParaInvasao == 0)
            {
                monstro.Nome = "Oni";
                monstro.Experiencia = 1000;
                monstro.VidaMax = 40;
                monstro.Ataque = 20;
                monstro.Destreza = 15;
                Combate(jogador, monstro); 
            }
        }

    }
}