using System;
using System.Collections.Generic;
using System.Text;

namespace Sithec.Humano.Persistencia.Models
{
    public class Humano
    {
        public int HumanoId { get; set; }

        public String Nombre { get; set; }

        public char Sexo { get; set; }

        public byte Edad { get; set; }

        public decimal Altura { get; set; }

        public decimal Peso { get; set; }
    }
}
