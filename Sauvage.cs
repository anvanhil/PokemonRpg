using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPokemon
{
    internal class Sauvage : Pokemon
    {
        private readonly string[] NomSauvage = {"Mewtoo","Pikachu","Ratata" };
        public  Sauvage()
        {
            Random random = new();
            Name = NomSauvage[random.Next(0, 3)];
            Health = random.Next(40, 100);
            Damage = random.Next(10, 20);
            Defense = random.Next(1, 5);
            Speed = random.Next(10, 20);
        }
        public int TakingDamage(int damages)
        {
            return Health -= damages - Defense;
        }
        public int Attack(int Damage)
        {
            return Damage;
        }
    }
    
}
