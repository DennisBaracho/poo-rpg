using System;
using System.Reflection;
using System.Threading.Tasks;
class CriacaoJogador : SistemaDeCombate
{
    public enum Classes { Samurai = 1, Ninja = 2, Xama = 3 }
    

    public CriacaoJogador()
    {
    
        Console.WriteLine("Ah, você apareceu. Diga-me, qual é o seu nome? Não há necessidade de ocultar sua identidade aqui. " +
            "\nNeste vasto mundo, seu nome será a lenda que ecoará através dos tempos.");
        nomeJogador = Console.ReadLine();
        nivelJogador = 1;
        experienciaJogador = 0;
        Console.WriteLine("\nMas antes de começarmos essa jornada épica, você deve escolher seu caminho. Você será um samurai, destemido e honrado, " +
            "\nou um ninja, ágil e astuto? Talvez você prefira a sabedoria dos monges ou a magia dos xamãs. \nA escolha é sua, e o destino aguarda " +
            "ansiosamente sua decisão.");
        Console.WriteLine("Selecione sua classe: \n1. Samurai\n2. Ninja\n3. Xamã");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Classes classeSelecionada = (Classes)index;
        switch(classeSelecionada){
            case Classes.Samurai:
                Console.WriteLine("Então você é um samurai...");
                classeJogador = "Samurai";
                vidaMaxima = 25;
                vidaAtual = vidaMaxima;
                ataqueJogador = 10;
                destrezaJogador = 10;
                Limpar(1500);
                break;
            case Classes.Ninja:
                Console.WriteLine("Então você é um ninja...");
                classeJogador = "Ninja";
                vidaMaxima = 20;
                vidaAtual = vidaMaxima;
                ataqueJogador = 10;
                destrezaJogador = 15;
                Limpar(1500);
                break;
            case Classes.Xama:
                Console.WriteLine("Então você é um xamã...");
                classeJogador = "Xamã";
                vidaMaxima = 20;
                vidaAtual = vidaMaxima;
                ataqueJogador = 25;
                destrezaJogador = 5;
                Limpar(1500);
                break;
            default:
                Console.WriteLine("Não existe essa opção");
                Limpar(1500);
                break;
            
        }
       
    }
}
