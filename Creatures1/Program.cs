using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatures1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animals a = new Animals();
            //a.name = "Foo";

            //Birds bird = new Birds();
            //bird.name = "F111";

            Mushrooms m1 = new Mushrooms();
            m1.name = "M1 misf";

            Mammals ma1 = new Mammals();
            ma1.name = "kdjskdjk";

            Console.WriteLine(m1.name);
            Console.ReadKey();
            //Console.WriteLine(bird.name + "\t" + bird.GetType());
            //Console.ReadKey();
        }
    }
}
