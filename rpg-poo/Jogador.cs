using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rpg_poo
{
    internal class Jogador 
    {
        // Atributos do Jogador
        private string nome;
        private string classe;
        private int nivel;
        private int vida;
        private int vidaMax;
        private int ataque;
        private int destreza;
        private int foraDeCombate;
        private int experiencia;

        // Get e Set
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
        public int Experiencia
        {
            get { return experiencia; }
            set { experiencia = value; }
        }
        public int Vida
        {
            get { return vida; }
            set { vida = value; }
        }
        public string Classe
        {
            get { return classe; }
            set { classe = value; }
        }
        public int VidaMax
        {
            get { return vidaMax; }
            set { vidaMax = value; }
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
        public int ForaDeCombate
        {
            get { return foraDeCombate; }
            set { foraDeCombate = value; }
        }
    }
   
    }
