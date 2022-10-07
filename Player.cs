using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spu111_weapons
{
    public class Player
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public IWeapon Weapon { get; set; }


        public void AttackPlayer(Player target)
        {
            if (Health <= 0) Console.WriteLine("Герой Умер");
            else
            {
                Weapon.Attack();
                target.Health -= Weapon.Damage;
                if (target.Health <= 0) Console.WriteLine("Враг убит");
            }
        }
        public void HealthCheck()
        {
            Console.WriteLine(Health);
        }
    }
}
