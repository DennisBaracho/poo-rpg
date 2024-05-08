using rpg_poo;
using System;
using System.Security.Principal;
class Monstro
{
    // Atributos do Monstro
    private string nome;
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
        string[] tipos = new string[5]
        {
        "Oni",
        "Rokurokubi",
        "Bakotsu",
        "Kappa",
        "Gashadokuro"
        };

        Random TipoDeMonstro = new Random();
        int rolagemTipo = TipoDeMonstro.Next(0, 4); 
        monstro.Nome = tipos[rolagemTipo];

        if (monstro.Nome == "Oni")
        {
            monstro.VidaMax = 15 + (jogador.Nivel*3);
            monstro.Ataque = 15 + (jogador.Nivel*2); 
            monstro.Destreza = 0;
        }
        else if (monstro.Nome == "Rokurokubi")
        {
            monstro.VidaMax = 1;
            monstro.Ataque = 15 + (jogador.Nivel*2);
            monstro.Destreza = 15 + (jogador.Nivel*2);
        }
        else if (monstro.Nome == "Bakotsu")
        {
            monstro.VidaMax = 15 + (jogador.Nivel*2); 
            monstro.Ataque = 10;
            monstro.Destreza = 10 + (jogador.Nivel*2);
        }
        else if (monstro.Nome == "Kappa")
        {
            monstro.VidaMax = 7 + (jogador.Nivel*4);
            monstro.Ataque = 7 + (jogador.Nivel*4);
            monstro.Destreza = 7 + (jogador.Nivel*4) ;
        }
    }
}
