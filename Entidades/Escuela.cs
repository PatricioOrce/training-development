using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Entidades
{
    public class Escuela
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public List<Persona> Alumnos { get; set; }
    }
}
