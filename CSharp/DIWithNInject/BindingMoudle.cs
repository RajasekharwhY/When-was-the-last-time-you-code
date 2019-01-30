using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code.DIWithNInject
{
    class BindingMoudle : NinjectModule
    {
        public override void Load()
        {
            Bind<IWeaponNinect>().To<swordNj>().Named("sword");
            //Bind<IWeaponNinect>().To<chakraNj>().Named("Chakra");
        }
    }
}
