using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LutaPokemon
{
    internal class Golpe
    {
		private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}
		private int poder;

		public int Poder
		{
			get { return poder; }
			set { poder = value; }
		}
		public Golpe()
		{
			this.nome = "";
			this.poder = 0;
		}
		
		public Golpe(string nome, int poder)
		{
			this.nome = nome;
			this.poder = poder;
		}

		public static Golpe[] setPlanta = new Golpe[4];
        public static Golpe[] setFogo = new Golpe[4];
        public static Golpe[] setAgua = new Golpe[4];
        public static Golpe[] setEletrico = new Golpe[4];
        public static Golpe[] setVoador = new Golpe[4];
        public static Golpe[] setNormal = new Golpe[4];
        public static Golpe[] setVeneno = new Golpe[4];
        public static Golpe[] setInseto = new Golpe[4];
        public static Golpe[] setTerra = new Golpe[4];
        public static Golpe[] setLutador = new Golpe[4];
        public static Golpe[] setPedra = new Golpe[4];
        public static Golpe[] setPsi = new Golpe[4];



        public static void ListadeGolpes()
		{

			setPlanta[0] = new Golpe("Razor Leaf", 30);
			setPlanta[1] = new Golpe("Vine Whip", 50);
			setPlanta[2] = new Golpe("Grass Knot", 20);
			setPlanta[3] = new Golpe("Solar Beam", 100);


			setFogo[0] = new Golpe("Ember", 31);
			setFogo[1] = new Golpe("Fire Ball", 52);
			setFogo[2] = new Golpe("Fire Fang", 22);
			setFogo[3] = new Golpe("Fire Blast", 98);


			setAgua[0] = new Golpe("Bubbles", 29);
			setAgua[1] = new Golpe("Water Gun", 54);
			setAgua[2] = new Golpe("Hydro Cannon", 105);
			setAgua[3] = new Golpe("Aqua Tail", 19);

			
			setEletrico[0] = new Golpe("Thunder Shock", 40);
			setEletrico[1] = new Golpe("Shockwave", 57);
			setEletrico[2] = new Golpe("Thunder", 102);
			setEletrico[3] = new Golpe("Thunder Punch", 19);


			setVoador[0] = new Golpe("Peck", 20);
			setVoador[1] = new Golpe("Wing Attack", 70);
			setVoador[2] = new Golpe("Drill Peck", 51);
			setVoador[3] = new Golpe("Quick Attack", 20);

			
			setNormal[0] = new Golpe("Quick Attack", 20);
			setNormal[1] = new Golpe("Bite", 50);
			setNormal[2] = new Golpe("Scratch", 50);
			setNormal[3] = new Golpe("Super Fang", 103);

		
			setVeneno[0] = new Golpe("Poison Fang", 15);
			setVeneno[1] = new Golpe("Gunk Shot", 53);
			setVeneno[2] = new Golpe("Acid", 22);
			setVeneno[3] = new Golpe("Poison Bomb", 70);


			setInseto[0] = new Golpe("String Shot", 23);
			setInseto[1] = new Golpe("Fury Cutter", 25);
			setInseto[2] = new Golpe("Pin Missile", 19);
			setInseto[3] = new Golpe("Bug Bite", 20);

			
			setTerra[0] = new Golpe("Sand Attack", 25);
			setTerra[1] = new Golpe("Mud Shot", 20);
			setTerra[2] = new Golpe("Mud Slap", 50);
			setTerra[3] = new Golpe("Earth Power", 90);

			
			setLutador[0] = new Golpe("Triple Kick", 30);
			setLutador[1] = new Golpe("Karate Cop", 55);
			setLutador[2] = new Golpe("Cross Crop", 88);
			setLutador[3] = new Golpe("Mega Punch", 104);

			Golpe[] setPsi = new Golpe[4];
			setPsi[0] = new Golpe("Psy Pulse", 30);
			setPsi[1] = new Golpe("Psychic", 80);
			setPsi[2] = new Golpe("Psybeam", 30);
			setPsi[3] = new Golpe("Dream Eater", 100);


			setPedra[0] = new Golpe("Rock Throw", 20);
			setPedra[1] = new Golpe("Rock Slide", 32);
			setPedra[2] = new Golpe("Rock Blast", 80);
			setPedra[3] = new Golpe("Falling Rocks", 105);
		}


	}
}
