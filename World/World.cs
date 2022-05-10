using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    public abstract class World
    {
        public int _countOfPeauple;

        public string _land;
        public World(string land)
        {
            _land = land;
        }
        public abstract string Nationality { get; set; }
        public abstract void Live();
    }
}
