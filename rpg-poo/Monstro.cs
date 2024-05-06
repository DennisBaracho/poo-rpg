using rpg_poo;
using System;
class Monstro 
{   
    // Atributos do Monstro
    private string nome = "Fubuki";
    private int vida = 20;
    private int vidaMax = 20;
    private int ataque = 10;
    private int destreza = 10;
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
}
