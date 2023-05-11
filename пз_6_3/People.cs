using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пз_6_3
{
    internal class People
    {
        public string Name { get; set; }
        public double Golova { get; set; }
        public int Tulovishe { get; set; }
        public int Ruki { get; set; }
        public int Nogi { get; set; }

        public People(string name, double golova,  int tulovishe, int ruki, int nogi)
        {
            Name = name;
            Golova = golova;    
            Tulovishe = tulovishe;
            Ruki = ruki;
            Nogi = nogi;
        }
    }
}
