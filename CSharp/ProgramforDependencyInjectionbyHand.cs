using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    class ProgramforDependencyInjectionbyHand
    {

        static void Main(string[] args)
        {
            soldier s1 = new soldier(new sword()); // Instanciating 
            soldier s2 = new soldier(new Chakra());

            // This is calleed dependency injection by hand because  
            // each time you want to create soldier object you need supply
            // or create a implementation of IWeapon (chakra, sword) and 
            // pass it to the soldier constructor 

            s1.Attack();
            s2.Attack();

        }
    }
}
