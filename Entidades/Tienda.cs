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
        public int ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }



        public Tienda(int iD, string name, string price)
        {
            ID = iD;
            this.Name = name;
            this.Price = price;
        }

        public string information()
        {
            return $"{Name} de valor {Price}";
        }
    }
}
