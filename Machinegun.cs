using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spu111_weapons
{
    internal class Machinegun : IWeapon
    {
        public double Health { get; set; }
        public double Damage { get; set; }
        public double Ammo { get; set; }

        public Machinegun()
        {
            Health = 200;
            Damage = 10;
            Ammo = 24;
        }

        public void Attack()
        {
            Console.WriteLine($"Выхватив автомат, главный герой сделал пару выстрелов во врага, нанеся {Damage} урона");
            Ammo -= 3;
            Console.WriteLine($"Считая патроны, главный герой помнит, что в магазине у него осталось {Ammo} патрон(а)");

            Health -= 3;

            if (Ammo <= 0) Console.WriteLine("Ваш магазин пуст! Перезарядитесь");
            if (Health <= 0) Console.WriteLine("Автомат сломался, купите новый");
        }
    }
}
