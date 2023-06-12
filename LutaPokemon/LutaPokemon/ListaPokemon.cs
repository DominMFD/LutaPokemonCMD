using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LutaPokemon
{
    internal class ListaPokemon
    {
        public static List<Pokemon> pokemons = new List<Pokemon>();

        public static void ListaPokemons()
        {
            Pokemon poke = new Pokemon("Bulbasaur", "Planta", 92, 200, 92, Golpe.setPlanta);
            pokemons.Add(poke);
            poke = new Pokemon("Charmander", "Fogo", 98, 188, 81, Golpe.setFogo);
            pokemons.Add(poke);
            poke = new Pokemon("Squirtle", "Agua", 90, 198, 121, Golpe.setAgua);
            pokemons.Add(poke);
            poke = new Pokemon("Pikachu", "Eletrico", 103, 180, 76, Golpe.setEletrico);
            pokemons.Add(poke);
            poke = new Pokemon("Pidgey", "Voador", 85, 190, 76, Golpe.setVoador);
            pokemons.Add(poke);
            poke = new Pokemon("Spearow", "Voador", 112, 190, 58, Golpe.setVoador);
            pokemons.Add(poke);
            poke = new Pokemon("Rattata", "Normal", 105, 170, 67, Golpe.setNormal);
            pokemons.Add(poke);
            poke = new Pokemon("Ekans", "Veneno", 112, 180, 83, Golpe.setVeneno);
            pokemons.Add(poke);
            poke = new Pokemon("Vulpix", "Fogo", 78, 186, 76, Golpe.setFogo);
            pokemons.Add(poke);
            poke = new Pokemon("Zubat", "Veneno", 85, 190, 67, Golpe.setVeneno);
            pokemons.Add(poke);
            poke = new Pokemon("Oddish", "Planta", 94, 200, 103, Golpe.setPlanta);
            pokemons.Add(poke);
            poke = new Pokemon("Paras", "Inseto", 130, 180, 103, Golpe.setInseto);
            pokemons.Add(poke);
            poke = new Pokemon("Diglett", "Terra", 103, 130, 49, Golpe.setTerra);
            pokemons.Add(poke);
            poke = new Pokemon("Psyduck", "Agua", 98, 210, 90, Golpe.setAgua);
            pokemons.Add(poke);
            poke = new Pokemon("Mankey", "Lutador", 148, 190, 67, Golpe.setLutador);
            pokemons.Add(poke);
            poke = new Pokemon("Growlithe", "Fogo", 130, 220, 85, Golpe.setFogo);
            pokemons.Add(poke);
            poke = new Pokemon("Poliwag", "Agua", 94, 190, 76, Golpe.setAgua);
            pokemons.Add(poke);
            poke = new Pokemon("Abra", "Psiquico", 40, 160, 31, Golpe.setPsi);
            pokemons.Add(poke);
            poke = new Pokemon("Machop", "Lutador", 148, 250, 94, Golpe.setLutador);
            pokemons.Add(poke);
            poke = new Pokemon("Geodude", "Pedra", 148, 190, 184, Golpe.setPedra);
            pokemons.Add(poke);
            poke = new Pokemon("Ponyta", "Fogo", 157, 210, 103, Golpe.setFogo);
            pokemons.Add(poke);
            poke = new Pokemon("Magnemite", "Eletrico", 67, 160, 130, Golpe.setEletrico);
            pokemons.Add(poke);
            poke = new Pokemon("Voltorb", "Eletrico", 58, 190, 94, Golpe.setEletrico);
            pokemons.Add(poke);
            poke = new Pokemon("Horsea", "Agua", 76, 170, 130, Golpe.setAgua);
            pokemons.Add(poke);
        }
    }
}
