using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    class FuncAndActions
    {
        static void Main(string[] args)
        {
            Func<int> returnInt = () => 2; 
            // func declaration uses ananymus mehtod (Lamda expression) to create func 
            Console.WriteLine(returnInt());
            // When you are returning the block of statements in side {} 
            // you have to use the return explicitly
            Func<int, string> retunStringOfaNumeric = (x) =>
            {
                return Convert.ToString(x);
            };
            Console.WriteLine(retunStringOfaNumeric(6));
            // Action will take paramters but did not return anything
            // Action is to perform some action but not return a value. 
            Action<int> actionToPrintInt = (x) => Console.WriteLine(x);
            actionToPrintInt(4);

            // Take multiple inputs and multiply
            Action<int, int> multiply = (x, y) => Console.WriteLine(x*y);
            multiply(8, 4);

            // print max of two ints
            Action<int, int> Max = (x, y) =>
               {
                   if (x > y)
                   {
                       Console.WriteLine(x);
                   }
                   else if (x < y)
                   {
                       Console.WriteLine(y);
                   }
               };
            Max(4, 5);
        }
    }
}
