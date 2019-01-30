using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using code.DIWithNInject;
using Ninject;

namespace code
{
    class ProgramforDependencyInjectionbyHand
    {

        static void Main(string[] args)
        {
            // Test with DI with NInjection
            IKernel kernel = new StandardKernel(new BindingMoudle());
            var sol = kernel.Get<soldier1>();
            sol.attackNj();
           

        }
    }
}
