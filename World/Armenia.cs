using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    public class Armenia : World
    {
        //_countOfPeauple = 3000000;  chi jarangvum abstract classi voch abstract fild@
        public override string Nationality { get; set; } = "ARM";

        public override void Live()
        {
            Console.WriteLine("So-So"); ;
        }
    }
}
