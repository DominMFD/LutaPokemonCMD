using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace LutaPokemon
{
    internal class Program
    {
      static Jogador jogador = new Jogador("Domiinguera");
      static Pokemon pokemon = new Pokemon();
        static void Main(string[] args)
        {
            Golpe.ListadeGolpes();
            jogador.PokemonInicial();
            ConsoleKey tecla;
            bool sair = true;

            while(sair) 
            { 
            Console.Clear();
            Console.WriteLine("=======LUTA POKEMON======");
            Console.WriteLine("1-Informaçoes do Treinador\n2-Lista de Pokemons Capturados\n3-Batalhar\n4-Sair");
            tecla = Console.ReadKey().Key;

            switch (tecla)
            {
                case ConsoleKey.D1:
                    jogador.InfoJogador();
                    break;
                case ConsoleKey.D2:
                    jogador.PokesCapturados();
                    break; 
                case ConsoleKey.D3:
                        Batalha(jogador.Selecionar(), pokemon.Inimigo());
                        break;
                case ConsoleKey.D4:
                    sair = false;
                    break;

            }
            }
            

        }

        static void Batalha(PokemonJogador pokeJogador, Pokemon pokeSelvagem)
        {

            int d;
            double vidapokejogador = pokeJogador.vida;
            double vidapokeselvagem = pokeSelvagem.vida;
            Random r = new Random();
            

            Console.Clear();
            Console.WriteLine("Prepare-se a batalha ira começar!");
            while(true)
            {
                Console.WriteLine("Escolha um golpe:");
                Console.WriteLine($"1-{pokeJogador.golpes[0].Nome}     2-{pokeJogador.golpes[1].Nome}      3-{pokeJogador.golpes[2].Nome}     4-{pokeJogador.golpes[3].Nome}");
                int g = int.Parse(Console.ReadLine());
                double danoJogador = pokeJogador.forca + pokeJogador.golpes[g-1].Poder + (pokeJogador.forca * 0.5);
                Console.WriteLine($"{pokeJogador.nome} : HP: {vidapokejogador} || {pokeSelvagem.nome} : HP: {vidapokeselvagem}" );
                Console.WriteLine($"{pokeJogador.nome} ataca {pokeSelvagem.nome} usando {pokeJogador.golpes[g-1].Nome} e causando {danoJogador - pokeSelvagem.def} de dano");
                vidapokeselvagem = vidapokeselvagem - (danoJogador - pokeSelvagem.def);
                if(vidapokeselvagem <= 0 )
                {
                    break;
                }

                d = r.Next(0,3);
                double danoSelvagem = pokeSelvagem.forca + pokeSelvagem.golpes[d].Poder + (pokeSelvagem.forca * 0.5);
                Console.WriteLine($"{pokeJogador.nome} : HP: {vidapokejogador} || {pokeSelvagem.nome} : HP: {vidapokeselvagem}");
                Console.WriteLine($"{pokeSelvagem.nome} ataca {pokeJogador.nome} usando {pokeSelvagem.golpes[d].Nome} e causando {danoSelvagem - pokeJogador.def}");
                vidapokejogador = vidapokejogador - (danoSelvagem - pokeJogador.def);
                if(vidapokejogador <= 0)
                {
                    break;
                }
            }

            if (vidapokejogador <= 0)
            {
                Console.WriteLine($"{pokeJogador.nome} foi derrotado");
                Console.WriteLine($"Que pena, voce perdeu a batalha e {pokeSelvagem.nome} fugiu");
                jogador.batPerd++;
                Console.WriteLine("Saindo da batalha....");
            }
            if (vidapokeselvagem <= 0)
            {
                Console.WriteLine($"{pokeSelvagem.nome} foi derrotado");
                Console.WriteLine("PARABENS!!!!!! Voce ganhou a partida");
                jogador.batVenc++;
                jogador.Capturar(pokeSelvagem);
            }

            Console.ReadKey();
        }
    }
}
