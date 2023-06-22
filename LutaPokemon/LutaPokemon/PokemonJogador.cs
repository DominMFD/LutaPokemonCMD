using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LutaPokemon
{
    internal class PokemonJogador : Pokemon
    {
        public int nivel;

        public int Nivel
        {
            get { if (exp >= 100)
                {
                    nivel++;
                    exp = exp - 100;
                }
                    
                return nivel;   
                        }
        }

        public int exp { set; get; }

        public PokemonJogador() :base() 
        {
            this.nivel = 1;
            this.exp = 0;
        }
        public PokemonJogador(string nome, string elemento, int forca, double vida, int def, Golpe[] golpes) : base(nome, elemento, forca, vida, def, golpes)
        {
            this.nivel = 1;
        }

        public void SubirNivel()
        {
            if (exp >= 100)
            {
                nivel++;
                Console.WriteLine("Seu pokemon subiu para o nivel " + nivel);
                exp = exp - 100;
            }
        }
       

    }
}
