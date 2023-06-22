using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LutaPokemon
{
    internal class Jogador
    {
        public string nome { set; get; }
        public int batVenc { set; get; }
        public int batPerd { set; get; }
        public int pokeCap { set; get; } 

        public Jogador() 
        {

        }
        public Jogador(string nome)
        {
            this.nome = nome;
  
        }

        public List<PokemonJogador> pokesJogador = new List<PokemonJogador>();

        public void PokemonInicial()
        {
            PokemonJogador pokemon = new PokemonJogador("Bulbasaur", "Planta", 92, 200, 92, Golpe.setPlanta);
            pokesJogador.Add(pokemon);
        }
        public void InfoJogador()
        {
            Console.Clear();
            Console.WriteLine("=======Informações do Treinador======");
            Console.WriteLine("Nome do Treinador: " + nome);
            Console.WriteLine("Batalhas Vencidas: " + batVenc);
            Console.WriteLine("Batalhas Perdidas:" + batPerd);
            Console.WriteLine("Quantidade de Pokemons Capturados: " +  pokesJogador.Count);
            Console.ReadKey();
        }

        public void PokesCapturados()
        {

            int id = 0;
            Console.Clear();
            Console.WriteLine("=======Pokemons Capturados=====");
            foreach(PokemonJogador pokemonJogador in pokesJogador)
            {
                Console.WriteLine("ID:" +  id);
                Console.WriteLine("Nome: " + pokemonJogador.nome);
                Console.WriteLine("Vida: " + pokemonJogador.vida);
                Console.WriteLine("Elemento: " + pokemonJogador.elemento);
                Console.WriteLine("Golpes: " + pokemonJogador.golpes[0].Nome +", "+ pokemonJogador.golpes[1].Nome +", "+ pokemonJogador.golpes[2].Nome +", "+ pokemonJogador.golpes[3].Nome) ;
                Console.WriteLine("Nivel: " + pokemonJogador.nivel);
                Console.WriteLine("Experiencia: " + pokemonJogador.exp);
                Console.WriteLine("========================");
                id++;
            }
            Console.ReadKey();
        }

        public PokemonJogador Selecionar() 
        { 
            PokesCapturados();
            Console.WriteLine("Digite o ID do Pokemon que deseja selecionar para a batalha:");
            int escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("Voce escolheu o : " + pokesJogador[escolha].nome);
            Console.ReadKey();
            return pokesJogador[escolha];
        }
       

        public void Capturar(Pokemon pokemonSelvagem)
        {
            Random r = new Random();
            PokemonJogador poke = new PokemonJogador();
            List<PokemonJogador> pokeencontrado = pokesJogador.FindAll(delegate (PokemonJogador p)
                    {
                        return p.nome.Equals(pokemonSelvagem.nome);
                    });

            int catchRate = r.Next(0, 100);
            Console.WriteLine($"Deseja capturar {pokemonSelvagem.nome} ? (s/n)");
            string escolha = Console.ReadLine().ToUpper();

            if (escolha == "S")
            {
                if (pokeencontrado.Count() > 0)
                {
                    Console.WriteLine("Voce já possui esse pokemon");
                }
                else
                {
                    Console.WriteLine("Pokebola Lançada.....");
                    Console.WriteLine("Capturando....");
                    if (catchRate > 48)
                    {
                        poke = new PokemonJogador(pokemonSelvagem.nome, pokemonSelvagem.elemento, pokemonSelvagem.forca, pokemonSelvagem.vida, pokemonSelvagem.def, pokemonSelvagem.golpes);
                        pokesJogador.Add(poke);
                        Console.WriteLine("Parabens!!! Voce capturou um " + pokemonSelvagem.nome);
                    }
                    else
                    {
                        Console.WriteLine("Que pena, sua pokebola quebrou.");
                        Console.WriteLine($"{pokemonSelvagem.nome} fugiu");
                    }

                }

            }
            else
            {
                Console.WriteLine("Saindo da batalha....");
            }

            Console.ReadKey();
        }
    }
}
