using System;
class MenuJogo : CriacaoJogador
{
    enum Opcao { Cacar = 1, Dormir, Eu, DiasAte }

    public static void Menu()
    {
        int diasParaInvasao = 7;

        while(diasParaInvasao > 0) { 
        Console.WriteLine("O que quer fazer? \n1. Caçar\n2. Dormir\n3. Me inspecionar \n4. Verificar dias até invasão");
        int menu = int.Parse(Console.ReadLine());
        Opcao opcaoSelecionada = (Opcao)menu;
        switch (opcaoSelecionada)
        {
            case Opcao.Cacar:
                    Combate();
                break;
            case Opcao.Dormir:
                Console.WriteLine("\nVocê está descansado!");
                diasParaInvasao--;
                vidaAtual = vidaMaxima;
                break;
            case Opcao.Eu:
                    Console.WriteLine("\nMeu nome é " + nomeJogador + ".\nNível: " + nivelJogador + "\nClasse: " + classeJogador + ". " +
                        "Meus atributos são: \nVida: (" + vidaAtual + "/" + vidaMaxima + ") \nAtaque: " + ataqueJogador + "\nDestreza: " + destrezaJogador +
                        "\nPontos de experiência: (" + experienciaJogador + "/" + (300 + (nivelJogador * 300)) + ")");
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
            nomeMonstro = "Oni";
            experienciaMonstro = 1000;
            vidaMaximaMonstro = 40;
            ataqueMonstro = 20;
            destrezaMonstro = 15;
            Combate();
        }
    }
}
