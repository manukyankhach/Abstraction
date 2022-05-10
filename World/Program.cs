using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    class Program
    {
        static void Main(string[] args)
        {
            //World world = new World(); abstract classic obyect chi sargvum
            List<World> world = new List<World>();
            world.Add(new Armenia());
            world.Add(new Russia());
            world[0].Live();
            world[1].Live();
            Console.ReadLine();
        }
    }
}
