using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Telefon : ICechy
    {
        public string Model { get; set; }
        public double Cena { get; set; }
        public string Marka { get; set; }
    }
}
