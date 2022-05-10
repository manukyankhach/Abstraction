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
        public abstract string Nationality { get; set; }
        public abstract void Live();
    }
}
