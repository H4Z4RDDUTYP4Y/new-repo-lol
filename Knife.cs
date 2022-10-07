using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spu111_weapons
{
    public class Knife : IWeapon
    {
        public double Health { get; set; }
        public double Damage { get; set; }

        public Knife()
        {
            Health = 100;
            Damage = 4;
        }

        public void Attack()
        {
            Console.WriteLine($"Достав нож, главный герой пырнул врага, нанеся ему {Damage} урона");

            Health -= 5;
            if(Health <= 0)
                Console.WriteLine("Ваш нож сломался, купите новый");
        }
    }
}
