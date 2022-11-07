using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace TpPokemon
{
    public class Pokemon

    {
        public Pokemon()
        {
            Name = "pokémon";
            Health = 100;
            Damage = 20;
            Defense = 3;
            Speed = 10;
        }
        public  Pokemon(string name, int health, int damage, int defense, int speed,int maxHealth, int level)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Defense = defense;
            Speed = speed;
            MaxHealth = maxHealth;
            Level = level;
  
            
        }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public int Defense { get; set; }

        public int Speed { get; set; }
        public int MaxHealth { get; set; }  
        public int Level { get; set; }




        public int TakingDamage(int damages)
        {
           return Health -= damages - Defense;
        }
        public int Attack(int Damage)
        {
            return Damage;
        }
        public int Potion(int potion)
        {
           return Health += potion;
        }

        public void Escape ()
        {
            var random = new Random();
            int escape = random.Next(1, 6);
            if (escape > 3)
            {
                Console.WriteLine("Vous avez réussi a vous échapper");
            }
            else
            {
               Console.WriteLine("Vous ne pouvez pas vous enfuir");
            }
        }
       
    }

    
}
