using System;
using System.Collections.Generic;
using System.Text;

namespace Sithec.Humano.Dto
{
    public class HumanoDto
    {
        public HumanoDto() { }

        public HumanoDto(int _Id, String _Nombre, char _Sexo, byte _Edad
            , decimal _Altura, decimal _Peso) 
        {
            this.Id = _Id;
            this.Nombre = _Nombre;
            this.Sexo = _Sexo;
            this.Edad = _Edad;
            this.Altura = _Altura;
            this.Peso = _Peso;            
        }

        public int Id { get; set; }

        public String Nombre { get; set; }

        public char Sexo { get; set; }

        public byte Edad { get; set; }

        public decimal Altura { get; set; }

        public decimal Peso { get; set; }
    }
}
