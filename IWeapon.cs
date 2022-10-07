using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spu111_weapons
{
    public interface IWeapon
    {
        double Health { get; set; }
        double Damage { get; set; }
        void Attack();
    }
}
