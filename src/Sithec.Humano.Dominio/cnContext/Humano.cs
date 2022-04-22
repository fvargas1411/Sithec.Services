using System;
using System.Collections.Generic;

#nullable disable

namespace Sithec.Humano.Dominio.cnContext
{
    public partial class Humano
    {
        public int HumanoId { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public byte Edad { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
    }
}
