using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatures1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals a = new Animals("Foo");
            Birds bird = new Birds("Birdy");
            Console.WriteLine(bird.name + "\t" + bird.GetType());
            Console.ReadKey();
        }
    }
}
