using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleNullables
{
    public class PlayerCharacter
    {
        private readonly ISpecialDefence _specialDefence;

        public PlayerCharacter(ISpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }

        public string Name { get; set; }
        public int? DaySinceLastLogin { get; set; }
        public int Health { get; set; } = 100;
        public DateTime? DateOfBirth { get; set; }
        //Nullable<T> == T?
        public Nullable<bool> IsNoob { get; set; }

        public void Hit(int damage)
        {
            //int damageReduction = 0;
            //damageReduction = _specialDefence.CalculateDamageReduction(damage);

            int totalDamageTaken = damage - _specialDefence.CalculateDamageReduction(damage);
            Health -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}.");
        }

    }
}
