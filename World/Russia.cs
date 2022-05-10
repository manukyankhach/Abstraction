using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    public class Russia : World
    {
        public override string Nationality { get; set; } = "RUS";

        public override void Live()
        {
            Console.WriteLine("Very Good");
        }
    }
}
