using rpg_poo;
using System;
using System.Security.Principal;
class Monstro
{
    // Atributos do Monstro
    private string nome;
    private string mensagem;
    private int vida;
    private int vidaMax;
    private int ataque;
    private int destreza;
    private int experiencia = 300;
   
    // Get e Set
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }
    public string Mensagem
    {
        get { return mensagem; }
        set { mensagem = value; }
    }
    public int Experiencia
    {
        get { return experiencia; }
        set { experiencia = value; }
    }
    public int VidaMax
    {
        get { return vidaMax; }
        set { vidaMax = value; }
    }
    public int Vida
    {
        get { return vida; }
        set { vida = value; }
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
    // Método de geração de monstros
    public void GerarMonstro(Monstro monstro, Jogador jogador)
    {
        string[] tipos = new string[4]
        {
        "Oni",
        "Rokurokubi",
        "Bakotsu",
        "Kappa",
        };

        Random TipoDeMonstro = new Random();
        int rolagemTipo = TipoDeMonstro.Next(0, 4); 
        monstro.Nome = tipos[rolagemTipo];

        if (monstro.Nome == "Oni")
        {
            monstro.Mensagem = "\nA sua frente está o Oni de pele avermelhada, com presas e chifres afiados, trata-se de um temido ogro, forte e resistente, porém um tanto caótico. " +
                "\nNão se sabe o que se passa em sua mente, mas o mal é seu guia.";
            monstro.VidaMax = 15 + (jogador.Nivel*3);
            monstro.Ataque = 15 + (jogador.Nivel*2); 
            monstro.Destreza = 0;
        }
        else if (monstro.Nome == "Rokurokubi")
        {
            monstro.Mensagem = "\nÀ noite, o Rokurokubi o observa com seu pescoço esticado e olhos brilhantes, como se flutuasse nas sombras. A criatura permanece estática, " +
                "sua mera  presença faz sua espinha arrepiar. Desse desconforto, o Yokai alegremente se alimenta.";
            monstro.VidaMax = 1;
            monstro.Ataque = 15 + (jogador.Nivel*2);
            monstro.Destreza = 15 + (jogador.Nivel*2);
        }
        else if (monstro.Nome == "Bakotsu")
        {
            monstro.Mensagem = "\nDos restos da guerra, o Bakotsu se ergue, seus ossos rangendo sinistramente a cada movimento. " +
                "Com olhos vazios e sorriso macabro, o cavalo de ossos desafia a mortalidade. Ágil e vigoroso, ele não deixará que passe.";
            monstro.VidaMax = 15 + (jogador.Nivel*2); 
            monstro.Ataque = 10;
            monstro.Destreza = 10 + (jogador.Nivel*2);
        }
        else if (monstro.Nome == "Kappa")
        {
            monstro.Mensagem = "\nDas águas do rio, o Kappa emerge sorrateiramente, sua cabeça em formato de prato e olhos astutos refletem a lua. " +
                "As mãos pegajosas e a carapaça verde e inocente mascaram sua verdadeira natureza.";
            monstro.VidaMax = 7 + (jogador.Nivel*4);
            monstro.Ataque = 7 + (jogador.Nivel*4);
            monstro.Destreza = 7 + (jogador.Nivel*4) ;
        }
    }
}
