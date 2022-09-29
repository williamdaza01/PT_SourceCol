using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptSourceCol
{
    internal class Carro
    {
        public string brand;
        public string color;
        public int model;

        public Carro(string brand, string color, int model)
        {
            this.brand = brand;
            this.color = color;
            this.model = model;
        }
    }
}
