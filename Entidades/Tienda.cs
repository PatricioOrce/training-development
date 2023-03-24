using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Training.Entidades
{
    internal class Tienda
    {
        public int ID;
        public string name;
        public string price;

        public Tienda(int iD, string name, string price)
        {
            ID = iD;
            this.name = name;
            this.price = price;
        }

        public string information()
        {
            return $"{name} de valor {price}";
        }
    }
}
