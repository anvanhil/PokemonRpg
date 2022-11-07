using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPokemon
{
    internal class Starter : Pokemon
    {
        public Starter(string nom)
        {
            Random random = new();
            Name = nom;
            Health = random.Next(80,100);
            Defense = random.Next(1,5);
            Damage = random.Next(15,30);
            Speed = random.Next(10,20);
            Level = 1;
        }
        public int TakingDamage(int damages)
        {
            return Health -= damages - Defense;
        }
        public int Attack(int Damage)
        {
            return Damage;
        }
        public void LevelUp()
        {
            Health += 10;
            Defense += 2;
            Damage += 5;
            Speed += 3;
        }
    }
}
