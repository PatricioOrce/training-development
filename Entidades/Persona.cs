﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Entidades
{
    public class Persona
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long Dni { get; set; }
        public TimeSpan FechaDeNacimiento { get; set; }
    }
}
