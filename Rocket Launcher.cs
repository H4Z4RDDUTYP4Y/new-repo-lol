using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spu111_weapons
{
    internal class Rocket_Launcher : IWeapon
    {
        public double Health { get; set; }
        public double Damage { get; set; }
        public double Ammo { get; set; }

        public Rocket_Launcher()
        {
            Health = 6;
            Damage = 30;
            Ammo = 3;
        }

        public void Attack()
        {
            Console.WriteLine($"Выхватив ракетомёт, главный герой сделал выстрел во врага, нанеся {Damage} урона");
            Ammo -= 1;
            Console.WriteLine($"Считая патроны, главный герой помнит, что у него осталось {Ammo} патрон(а)");

            Health -= 1;

            if (Ammo <= 0) Console.WriteLine("Перезарядитесь!");
            if (Health <= 0) Console.WriteLine("Ракетомет сломался, купите новый");
        }
    }
}
