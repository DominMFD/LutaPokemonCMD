using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LutaPokemon
{
    internal class PokemonJogador : Pokemon
    {
        public int nivel { set; get; }
        public int exp { set; get; }

        public PokemonJogador() :base() 
        {
            this.nivel = 1;
            this.exp = 0;
        }
        public PokemonJogador(string nome, string elemento, int forca, double vida, int def, Golpe[] golpes) : base(nome, elemento, forca, vida, def, golpes)
        {
 
        }
       

    }
}
