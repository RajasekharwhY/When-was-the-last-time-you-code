using System;

namespace code
{
    class DIwithNinject
    {
    }
    
    class soldier1
    {
        readonly IWeaponNinect weaponNj;

       public soldier1(IWeaponNinect weapon)
        {
            weaponNj = weapon;
        }

        public void attackNj()
        {
            weaponNj.HitNineject();
        }
    }

    interface IWeaponNinect
    {
        void HitNineject();
    }

    class swordNj : IWeaponNinect
    {
        public void HitNineject()
        {
            Console.WriteLine("Print sword HIT NIninect");
        }
    }

    class chakraNj : IWeaponNinect
    {
        public void HitNineject()
        {
            Console.WriteLine("Print chakra ninect");
        }
    }
}
