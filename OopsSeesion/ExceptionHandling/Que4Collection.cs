using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ExceptionHandling
{
    class Player
    {
        int id;
        string name, country, team;

        public Player(int id, string name, string country, string team)
        {
            this.Id = id;
            this.Name = name;
            this.Country = country;
            this.Team = team;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public string Team { get => team; set => team = value; }
    }
    class Que4Collection
    {
        static void Main(string[] args)
        {
            Player[] p = new Player[3];
            p[0]=new Player(1,"MSDhoni","India","Chennai Super Kings");
            Console.WriteLine(p[0].Id);
            Console.WriteLine(p[0].Name);
            Console.WriteLine(p[0].Country);
            Console.WriteLine(p[0].Team);
           

        }
    }
}
