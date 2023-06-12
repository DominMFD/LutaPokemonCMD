using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LutaPokemon
{
    internal class Pokemon
    {
        public string nome { get; set; }
        public string elemento { get; set; }
        public int forca { get; set; }
        public double vida { get; set; }
        public int def { get; set; }
        public Golpe[] golpes { get; set; }

        public Pokemon()
        {

        }
        public Pokemon(string nome, string elemento, int forca, double vida, int def, Golpe[] golpes)
        {
            this.golpes = golpes;
            this.nome = nome;
            this.elemento = elemento;
            this.forca = forca;
            this.vida = vida;
            this.def = def;
            this.golpes = golpes;
        }

        public Pokemon Inimigo()
        {

            Random r = new Random();
            int i;
            ListaPokemon.ListaPokemons();
            i = r.Next(0, ListaPokemon.pokemons.Count);
            Console.WriteLine("Voce encontrou um inimigo!");
            Console.WriteLine("Prepare-se para lutar contra " + ListaPokemon.pokemons[i].nome);
            Console.ReadLine();
            return ListaPokemon.pokemons[i];

        }
    }
}
