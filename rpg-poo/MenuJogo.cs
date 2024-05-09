using rpg_poo;
using System;
using System.Security.Cryptography.X509Certificates;
class MenuJogo : SistemaDeCombate
{
    enum Opcao { Cacar = 1, Dormir, Eu, DiasAte, Ajuda }

    public static void Menu(Jogador jogador)
    {
        {
            while (jogador.NoitesSobrevividas < 7)
            {
                Console.WriteLine("Um reflexo distorcido do que já foi, Maōmachi pede socorro. Para chegar até a residência de sua família, circundada de criaturas, " +
                    "serão necessários longos e intensos dias de luta, os Yokais não parecem sair de seus postos.\n\n" +
                    "O que quer fazer? \n1. Caçar \n2. Dormir \n3. Me inspecionar \n4. Verificar dias até invasão \n5. Ajuda");
                int menu = int.Parse(Console.ReadLine());
                Opcao opcaoSelecionada = (Opcao)menu;
                switch (opcaoSelecionada)
                {
                    case Opcao.Cacar:
                        Combate(jogador);
                        Limpar(2000);
                        break;
                    case Opcao.Dormir:
                        Console.WriteLine("\nVocê descansa em um abrigo. Vida e mana estão totalmente recuperados!");
                        jogador.NoitesSobrevividas++;
                        jogador.Vida = jogador.VidaMax;
                        jogador.Mana = jogador.ManaMax;
                        Limpar(2000);
                        break;
                    case Opcao.Eu:
                        Console.WriteLine("\nMeu nome é " + jogador.Nome + ".\nNível: " + jogador.Nivel + "\nClasse: " + jogador.Classe + ". " +
                            "\nMeus atributos são: \nVida: (" + jogador.Vida + "/" + jogador.VidaMax + ") | Mana: (" + jogador.Mana + "/" + jogador.ManaMax + ") \nAtaque: " + jogador.Ataque + "\nDestreza: " + jogador.Destreza +
                            "\nPontos de experiência: (" + jogador.Experiencia + "/" + (300 + (jogador.Nivel * 300)) + ")");
                        Limpar(6000);
                        break;
                    case Opcao.DiasAte:
                        Console.WriteLine("\nFaltam " + (7-jogador.NoitesSobrevividas) + " dias para a profecia do sábio.");
                        Limpar(2000);
                        break;
                    case Opcao.Ajuda:
                        Console.WriteLine("\nResumo de atributos:\nVIDA é o atributo que mantém seu personagem vivo, caso ele zere, o jogo acaba." +
                            "\nATAQUE é utilizado nas rolagens de acerto e dano aos inimigos.\nDESTREZA é utilizado para desviar de ataques de inimigos.\n\nAtaque especial:");
                        if(jogador.Classe == "Samurai")
                        {
                            Console.WriteLine("VENTOS REVIGORANTES: Seu personagem se cura em metade da Vida Máxima, " + ((jogador.VidaMax) / 2) + " pontos de Vida. Custo: 5 de Mana.");
                        }
                        else if(jogador.Classe == "Ninja")
                        {
                            Console.WriteLine("LÂMINA DAS SOMBRAS: Seu personagem ataca o inimigo furtivamente pelas costas, tendo acerto garantido e dano baseado na Destreza. Custo: 2 de Mana.");
                        }
                        else
                        {
                            Console.WriteLine("RITUAL VAMPÍRICO: Seu personagem rouba a energia vital do oponente, causando dano garantido e se curando em metade do dano causado.");
                        }
                        Limpar(6000);
                        break;
                    default:
                        Console.WriteLine("\nNão existe essa opção\n");
                        break;
                }
            }
            Combate(jogador);
        }

    }
}