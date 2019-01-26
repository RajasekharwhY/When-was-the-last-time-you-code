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
            
            // for smaller projects this creation of objects and pass it to the 
            // constructor is easy, but for compplex projects and things like
            // caching, logging, tracing, auditing etc.. it is difficult to 
            // add for each objects, in these cases containers like Ninject will be
            // a great help.

            s1.Attack();
            s2.Attack();

        }
    }
}
