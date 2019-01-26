using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    class DependencyInjectionbyHand
    {
        
        
    }

    class soldier
    {
        private readonly IWeapon weapon;
        public soldier(IWeapon Soldierweapon)
        {
            weapon = Soldierweapon;
        }

        public void Attack()
        {
            weapon.Hit();
        }
    }

    interface IWeapon
    {
        void Hit();
    }

    class sword : IWeapon
    {
        public void Hit()
        {
            Console.WriteLine("Sword - Cut Into two halfs");
        }
    }

    class Chakra : IWeapon
    {
        public void Hit()
        {
            Console.WriteLine("Chakra - Cut Into two halfs");
        }
    }
}
